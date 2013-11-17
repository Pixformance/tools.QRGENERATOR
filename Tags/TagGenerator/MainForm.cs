using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagGenerator
{
    public partial class MainForm : Form
    {
        static readonly int _QR_PER_PAGE = 20; // this is tied to the PDF layout so don't change this without touching the layout 

        // configured during "import" page
        string _csv_filename;               // set when the user selects a file to import the QR codes
        int _max_qr_used;                   // read from the imported CSV file or set to 0 when no file was used
        int _max_page_number_used;          // read from the imported CSV file or set to 0 when no file was used

        // configured during "configure" page
        string _output_dir;
        int _requested_pages_count = 1;
        int _requested_qr_count = _QR_PER_PAGE;

        // used within the "Generate" page
        BackgroundWorker worker;

        public MainForm()
        {
            InitializeComponent();

            //// configure pages of our wizard

            // 1. Welcome

            // 2. Import

            page_import.Commit +=
                delegate(object sender, AeroWizard.WizardPageConfirmEventArgs e)
                {
                    // odd case when no decision was made, abort:
                    if (!import_rb_dontimport.Checked && !import_rb_import.Checked)
                    {
                        e.Cancel = true;
                        return;
                    }
                    if (import_rb_dontimport.Checked)
                    {
                        _max_qr_used = 0;
                        _max_page_number_used = 0;
                    }
                    // the other case is already handled during the input and the variables are set
                };

            // 3. Configure

            config_lbl_num_qr_per_page.Text = _QR_PER_PAGE.ToString();

            page_configure.Commit +=
                delegate(object sender, AeroWizard.WizardPageConfirmEventArgs e)
                {
                    _requested_pages_count = Convert.ToInt32(config_pagescount.Value);
                    _requested_qr_count = _requested_pages_count * _QR_PER_PAGE;
                };
            
            // 4. Generate
            worker = new BackgroundWorker();

            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;

            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;

            page_generate.Initialize +=
                delegate(object sender, AeroWizard.WizardPageInitEventArgs e)
                {
                    worker.RunWorkerAsync();
                };
        }


        class GenerateProgressReport
        {
            public bool UpdateGeneratedCodes { get; set; }
            public bool UpdateGeneratedPages { get; set; }

            public int GeneratedCodes { get; set; }
            public int GeneratedPages { get; set; }

            public bool UpdateMsg { get; set; }
            public string Msg { get; set; }

            public bool UpdateProgress { get; set; }
            public int Progress { get; set; }
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (null != e.Error)
            {
                gen_tb_msg.AppendText("Error:" + System.Environment.NewLine);
                gen_tb_msg.AppendText(e.Error.Message);
                return;
            }

            page_generate.AllowNext = true;
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            GenerateProgressReport report = e.UserState as GenerateProgressReport;

            if (null == report)
                return;

            if (report.UpdateMsg)
            {
                gen_tb_msg.AppendText(report.Msg + System.Environment.NewLine);
            }

            if (report.UpdateProgress)
            {
                gen_pb.Value = report.Progress;
            }

            if (report.UpdateGeneratedCodes)
            {
                gen_lbl_generatedQR.Text = String.Format(
                    "{0} of {1}",
                    report.GeneratedCodes,
                    _requested_qr_count);
            }

            if (report.UpdateGeneratedPages)
            {
                gen_lbl_generatedPages.Text = String.Format(
                    "{0} of {1}",
                    report.GeneratedPages,
                    _requested_pages_count);
            }
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker w = sender as BackgroundWorker;
            if (null == w)
                return;

            w.ReportProgress(0, new GenerateProgressReport()
            {
                UpdateProgress = true, Progress = 0,
                UpdateGeneratedPages = true, GeneratedPages = 0,
                UpdateGeneratedCodes = true, GeneratedCodes = 0
            });

            // okay, so now the serious stuff has to happen...

            for (int page_count = 0; page_count < _requested_pages_count; page_count++)
            {
                // 1. Generate QR codes for this page and their serial numbers
                

                // 2. Create the PDF

                w.ReportProgress(0, new GenerateProgressReport()
                {
                    UpdateProgress = true,
                    Progress = 0,
                    UpdateGeneratedPages = true,
                    GeneratedPages = page_count + 1,
                    UpdateGeneratedCodes = true,
                    GeneratedCodes = (page_count + 1) * _QR_PER_PAGE
                });
            }
        }


        #region IMPORT PAGE
        

        // IMPORT PAGE
        // what to do when radio buttons change their values:

        private void import_rb_dontimport_CheckedChanged(object sender, EventArgs e)
        {
            // the don't import rb was checked or unchecked.
            // if checked, then allow 'next' on this wizard because the user is not importing any data
            if (import_rb_dontimport.Checked)
                page_import.AllowNext = true;
        }

        private void import_rb_import_CheckedChanged(object sender, EventArgs e)
        {
            // the import rb was changed
            // if checked, then disable the next button (because there are more steps to execute)
            //              and show the config panel
            // if unchecked, then hide the config panel, don't care for the next button, this is handled
            //              in the other rb code
            //              
            if (import_rb_import.Checked)
            {
                import_panel_import.Visible = true;
                import_panel_import.Enabled = true;
                page_import.AllowNext = false;

                _csv_filename = String.Empty;
                import_lbl_file.Text = "";
                import_lbl_report.Text = "";
            }
            else
            {
                import_panel_import.Visible = false;
                import_panel_import.Enabled = false;
            }
        }

        // user selects the file, let's just remember the file location, that's it for now
        private void btn_select_csv_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "CSV files|*.csv|All files|*.*";
            dialog.Title = "Open generated QR Codes (CSV file)";

            DialogResult dr = dialog.ShowDialog();

            if (DialogResult.OK == dr)
            {
                _csv_filename = dialog.FileName;
                import_lbl_file.Text = _csv_filename;

                // the file has changed, don't go to the next page yet, first import must happen
                page_import.AllowNext = false;
                import_lbl_report.Text = String.Empty;
            }
        }

        // okay, user decided to import the file, let's then import it..
        // no background threads and so on, because the files are going to
        // be small for now (10-50 mb is small, reading it will take a second or two)
        private void import_btn_import_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(_csv_filename))
            {
                MessageBox.Show(
                    "Please specify the input file first.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (!File.Exists(_csv_filename))
            {
                MessageBox.Show(
                    String.Format("File '{0}' doesn't exist", _csv_filename),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            // we'll find the max qr code used and the max page number used
            int max_qr_code = 0;
            int max_page_number = 0;

            char[] separators = new char[] { ',' };

            // please note: this is an iterator, it does not load the entire
            // file and we don't know the exact count of lines, so there is no progress
            // to display.
            // 
            // file format
            // //qr_code,serial_number,page_number,software_version,generation_timestamp
            // "//" skips the line (so that comments are allowed)

            IEnumerable<string> fileReader = null;

            try
            {
                fileReader = File.ReadLines(_csv_filename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    String.Format("File '{0}' can't be open.", _csv_filename) +
                    System.Environment.NewLine +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            int linesRead = 0; int linesProcessed = 0;

            foreach (string line in fileReader)
            {
                linesRead++;

                if (line.StartsWith("//"))
                    continue;

                string[] parts = line.Split(separators);

                if (parts.Length != 5)
                    continue;

                int current_qr; int current_page;

                if (Int32.TryParse(parts[0], out current_qr) && Int32.TryParse(parts[2], out current_page))
                {
                    max_qr_code = Math.Max(max_qr_code, current_qr);
                    max_page_number = Math.Max(max_page_number, current_page);
                }

                linesProcessed++;
            }

            import_lbl_report.Text =
                String.Format(
                    "Read {0} lines, ignored {1}, processed {2}\n" +
                    "Max QR Code found: {3}\n" +
                    "Max page number found: {4}",
                    linesRead, linesRead - linesProcessed, linesProcessed,
                    max_qr_code,
                    max_page_number);

            _max_page_number_used = max_page_number;
            _max_qr_used = max_qr_code;

            page_import.AllowNext = true;
        }
        #endregion

        #region CONFIG PAGE


        private void config_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                config_lbl_output_dir.Text = dialog.SelectedPath;
                _output_dir = dialog.SelectedPath;

                page_configure.AllowNext = true;
            }
        }

        #endregion

    }
}
