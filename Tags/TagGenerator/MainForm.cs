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
        static readonly int _QR_PER_PAGE = 2*4; // this is tied to the PDF layout so don't change this without touching the layout 

        // configured during "import" page
        string _csv_filename;               // set when the user selects a file to import the QR codes
        //UInt32 _max_qr_used;                   // read from the imported CSV file or set to 0 when no file was used
        int _max_page_number_used;          // read from the imported CSV file or set to 0 when no file was used

        // configured during "configure" page
        string _output_dir;
        int _requested_pages_count = 1;
        int _requested_qr_count = _QR_PER_PAGE;

        PseudoRandomCodeGenerator generator = new PseudoRandomCodeGenerator();

        // used within the "Generate" page
        BackgroundWorker worker;
        List<Tuple<UInt32, int>> _generated_codes = new List<Tuple<UInt32, int>>(); // keeps all generated codes in memory
                                                                                 // they will be written out to a file later
                                                                                 // content: qr as int and the page number
                                                                                 //          the serial number will be generated

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
                        //_max_qr_used = 0;
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
                    // don't generate if somebody just goes back through that page
                    if (e.PreviousPage == page_configure)
                    {
                        worker.RunWorkerAsync();
                        gen_btn_abort.Enabled = true;
                    }
                };

            page_generate.Rollback += delegate(object sender, AeroWizard.WizardPageConfirmEventArgs e)
            {
                if (worker.IsBusy)
                {
                    e.Cancel = true;
                }
            };

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
            //UInt32 max_qr_code = 0;
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
                    //max_qr_code = Math.Max(max_qr_code, current_qr);
                    UInt32 qrShouldBe = generator.next();
                    if (current_qr != qrShouldBe)
                    {
                        MessageBox.Show(
                            String.Format("QR Code '{0}' is not in the right order", current_qr) +
                            System.Environment.NewLine +
                            String.Format("Should be {0}", qrShouldBe),
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return;
                    }

                    max_page_number = Math.Max(max_page_number, current_page);
                }

                linesProcessed++;
            }

            import_lbl_report.Text =
                String.Format(
                    "Read {0} lines, ignored {1}, processed {2}\n" +
                    //"Max QR Code found: {3}\n" +
                    "Max page number found: {3}",
                    linesRead, linesRead - linesProcessed, linesProcessed,
                    //max_qr_code,
                    max_page_number);

            _max_page_number_used = max_page_number;
            //_max_qr_used = max_qr_code;

            page_import.AllowNext = true;
        }
        #endregion

        #region CONFIG PAGE


        private void config_btn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    config_lbl_output_dir.Text = dialog.SelectedPath;
                    _output_dir = dialog.SelectedPath;

                    page_configure.AllowNext = true;
                }
            }
        }

        #endregion

        #region GENERATE PAGE


        public class GenerateProgressReport
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

        void ReportProgressForwarder(GenerateProgressReport action)
        {
            worker.ReportProgress(0, action);
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

            Action<GenerateProgressReport> reportProgressDelegate = new Action<GenerateProgressReport>(ReportProgressForwarder);

            reportProgressDelegate(new GenerateProgressReport()
            {
                UpdateProgress = true,
                Progress = 0,
                UpdateGeneratedPages = true,
                GeneratedPages = 0,
                UpdateGeneratedCodes = true,
                GeneratedCodes = 0
            });

            for (int page_count = 0; page_count < _requested_pages_count; page_count++)
            {
                if (w.CancellationPending)
                {
                    reportProgressDelegate(new GenerateProgressReport()
                    {
                        UpdateMsg = true
                    });
                    reportProgressDelegate(new GenerateProgressReport()
                    {
                        UpdateMsg = true,
                        Msg = "The process was aborted by the user."
                    });
                    return;
                }
                // this is important, from now on this is where we're tracking the generated qr codes and pages!
                int page_generating = _max_page_number_used + 1; // the number of page being generated
                //UInt32 max_qr_generated = _max_qr_used; // this is the max of the qr codes generated during this page creation
                // it will be committed (copied to _max_qr_used) after the page was written

                List<Tuple<UInt32, int>> tmp_generated_codes = new List<Tuple<UInt32, int>>(_QR_PER_PAGE);

                try
                {
                    // build filename
                    string filename = null;
                    int filename_create_attempts = 0;
                    do
                    {
                        filename = Path.Combine(
                            _output_dir,
                            String.Format("pix_qr_{0}{1}.pdf",
                            page_generating,
                            filename_create_attempts > 0 ? "(" + filename_create_attempts + ")" : "") // if this file exists.
                            );

                        filename_create_attempts++;

                        // hmm.. just to be safe here that there is no bug 
                        if (filename_create_attempts > 1000)
                        {
                            throw new Exception("Failed to generate a filename for the output file.");
                        }
                    } while (File.Exists(filename));

                    reportProgressDelegate(new GenerateProgressReport()
                    {
                        UpdateMsg = true,
                        Msg = String.Format("Creating file {0}", Path.GetFileName(filename))
                    });

                    //// create the PDF:
                    // first the basics

                    iTextSharp.text.pdf.BaseFont bf = iTextSharp.text.pdf.BaseFont.CreateFont(
                        iTextSharp.text.pdf.BaseFont.HELVETICA,
                        iTextSharp.text.pdf.BaseFont.CP1252, true);

                    iTextSharp.text.Font font_title = new iTextSharp.text.Font(
                        bf,
                        11,
                        iTextSharp.text.Font.BOLD + iTextSharp.text.Font.UNDERLINE,
                        iTextSharp.text.Color.DARK_GRAY);

                    iTextSharp.text.Font font_description = new iTextSharp.text.Font(
                                    bf,
                                    11,
                                    iTextSharp.text.Font.NORMAL,
                                    iTextSharp.text.Color.DARK_GRAY);

                    iTextSharp.text.Font font_meta = new iTextSharp.text.Font(
                                    bf,
                                    8,
                                    iTextSharp.text.Font.NORMAL,
                                    iTextSharp.text.Color.DARK_GRAY);

                    iTextSharp.text.Font font_sn = new iTextSharp.text.Font(
                                    bf,
                                    12,
                                    iTextSharp.text.Font.NORMAL,
                                    iTextSharp.text.Color.DARK_GRAY);

                    iTextSharp.text.Font font_web = new iTextSharp.text.Font(
                                    bf,
                                    10,
                                    iTextSharp.text.Font.NORMAL,
                                    iTextSharp.text.Color.DARK_GRAY);


                    iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);

                    // and now let's build it
                    iTextSharp.text.pdf.PdfWriter pdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(filename, FileMode.Create));
                    doc.Open();

                    doc.SetMargins(30.0f, 30.0f, 0.0f, 0.0f);

                    iTextSharp.text.Paragraph header = new iTextSharp.text.Paragraph();
                    header.SpacingBefore = 0.0f;
                    header.SpacingAfter = 0.0f;
                    header.Add(new iTextSharp.text.Chunk("Pixformance Membership Tags", font_title));
                    header.Add(iTextSharp.text.Chunk.NEWLINE);
                    header.Add(new iTextSharp.text.Chunk("Bitte vor der ersten Benutzung aktivieren.", font_description));
                    doc.Add(header);

                    iTextSharp.text.Paragraph meta = new iTextSharp.text.Paragraph();
                    meta.SpacingBefore = 0.0f;
                    meta.SetAlignment("Right");
                    meta.Add(new iTextSharp.text.Chunk(
                        String.Format(
                            "{0} Tags | {1} | Version {2}",
                            _QR_PER_PAGE, page_generating, Application.ProductVersion),
                        font_meta));
                    doc.Add(meta);

                    iTextSharp.text.pdf.PdfPTable qr_table = new iTextSharp.text.pdf.PdfPTable(2);
                    qr_table.TotalWidth = 2.0f * 255.0f;
                    qr_table.SpacingBefore = 72.0f;
                    qr_table.LockedWidth = true;

                    for (int qr_count = 0; qr_count < _QR_PER_PAGE; qr_count++)
                    {
                        iTextSharp.text.pdf.PdfPTable oneCard_table = new iTextSharp.text.pdf.PdfPTable(3);
                        oneCard_table.TotalWidth = 255.0f;
                        float[] columnWidths = new float[] { 1, 5, 1 };
                        oneCard_table.SetWidths(columnWidths);
                        oneCard_table.LockedWidth = true;

                        //int qr_code_generating = max_qr_generated + 1; // the value of a qr code being generated
                        UInt32 qr_code_generating = generator.next();
                        tmp_generated_codes.Add(new Tuple<UInt32, int>(qr_code_generating, page_generating));

                        System.Drawing.Image qr_code = QRProvider.Generate("01" + qr_code_generating.ToString(), reportProgressDelegate);

                        if (null == qr_code)
                        {
                            throw new Exception("QR Code generation failed. Page would be incomplete. Aborting this page.");
                        }

                        string serial_number = SerialNumber.Generate(qr_code_generating);

                        iTextSharp.text.Image qr_image = iTextSharp.text.Image.GetInstance(
                            qr_code,
                            iTextSharp.text.Color.WHITE);
                        qr_image.ScaleAbsolute(120f, 120f);

                        iTextSharp.text.Phrase phrQR = new iTextSharp.text.Phrase();
                        phrQR.Add(new iTextSharp.text.Chunk(qr_image, 0, 0));
                        phrQR.Add(iTextSharp.text.Chunk.NEWLINE);
                        phrQR.Add(new iTextSharp.text.Chunk("http://my.pixformance.com", font_web));

                        iTextSharp.text.Image pixLogo = iTextSharp.text.Image.GetInstance("x:\\tools.QRGENERATOR\\logosmall.png");
                        pixLogo.ScalePercent(55f, 55f);
                        iTextSharp.text.pdf.PdfPCell cellLogo = new iTextSharp.text.pdf.PdfPCell(pixLogo);
                        cellLogo.HorizontalAlignment = iTextSharp.text.pdf.PdfPCell.ALIGN_CENTER;
                        cellLogo.VerticalAlignment = iTextSharp.text.pdf.PdfPCell.ALIGN_MIDDLE;
                        cellLogo.MinimumHeight = 153.0f;
                        cellLogo.Rotation = 90;
                        cellLogo.BorderWidth = 0.0f;
                        oneCard_table.AddCell(cellLogo);

                        iTextSharp.text.pdf.PdfPCell cellQR = new iTextSharp.text.pdf.PdfPCell(phrQR);
                        cellQR.HorizontalAlignment = iTextSharp.text.pdf.PdfPCell.ALIGN_CENTER;
                        cellQR.VerticalAlignment = iTextSharp.text.pdf.PdfPCell.ALIGN_MIDDLE;
                        cellQR.MinimumHeight = 153.0f;
                        cellQR.BorderWidth = 0.0f;
                        oneCard_table.AddCell(cellQR);

                        iTextSharp.text.Phrase phrSerial = new iTextSharp.text.Phrase();
                        //phrQR.Add(iTextSharp.text.Chunk.NEWLINE);
                        phrSerial.Add(new iTextSharp.text.Chunk(serial_number, font_sn));

                        iTextSharp.text.pdf.PdfPCell cellSerial = new iTextSharp.text.pdf.PdfPCell(phrSerial);
                        cellSerial.HorizontalAlignment = iTextSharp.text.pdf.PdfPCell.ALIGN_CENTER;
                        cellSerial.VerticalAlignment = iTextSharp.text.pdf.PdfPCell.ALIGN_MIDDLE;
                        cellSerial.MinimumHeight = 153.0f;
                        cellSerial.Rotation = -90;
                        cellSerial.BorderWidth = 0.0f;
                        oneCard_table.AddCell(cellSerial);

                        iTextSharp.text.pdf.PdfPCell cellCard = new iTextSharp.text.pdf.PdfPCell(oneCard_table);
                        cellCard.HorizontalAlignment = iTextSharp.text.pdf.PdfPCell.ALIGN_CENTER;
                        cellCard.VerticalAlignment = iTextSharp.text.pdf.PdfPCell.ALIGN_MIDDLE;
                        cellCard.MinimumHeight = 153.0f;
                        cellCard.BorderWidth = 1.0f;
                        qr_table.AddCell(cellCard);

                        w.ReportProgress(0, new GenerateProgressReport()
                        {
                            UpdateGeneratedCodes = true,
                            GeneratedCodes = (_QR_PER_PAGE * page_count) + qr_count + 1
                        });

                        //max_qr_generated = qr_code_generating;
                    }

                    doc.Add(qr_table);

                    doc.Close();

                    w.ReportProgress(0, new GenerateProgressReport()
                    {
                        UpdateGeneratedPages = true,
                        GeneratedPages = page_count + 1,
                        UpdateProgress = true,
                        Progress = (100 * (page_count + 1) / _requested_pages_count)
                    });

                    // all worked, so let's commit in memory here
                    _max_page_number_used = page_generating;
                    //_max_qr_used = max_qr_generated;

                    _generated_codes.AddRange(tmp_generated_codes);
                }
                catch (Exception ex)
                {
                    w.ReportProgress(0, new GenerateProgressReport()
                    {
                        UpdateMsg = true,
                        Msg = String.Format("Error during PDF creation: {0}", ex.Message)
                    });
                }
            }
        }
        #endregion

        #region EXPORT PAGE
        private void export_btn_Click(object sender, EventArgs e)
        {
            /*
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "CSV files|*.csv|All files|*.*";
            dialog.Title = "Export generated QR Codes (CSV file)";
            dialog.DefaultExt = "csv";

            DialogResult dr = dialog.ShowDialog();

            if (DialogResult.OK != dr)
                return;
            */
            //string fname = dialog.FileName;
            string fname = textBoxExport.Text;

            string source_old_codes = null;
            if (!String.IsNullOrEmpty(_csv_filename))
            {
                // often users will overwrite the old file, so let's already work like it's the regular case
                string temp_file = Path.GetTempFileName();
                if (File.Exists(temp_file))
                    File.Delete(temp_file);
                File.Copy(_csv_filename, temp_file);
                source_old_codes = temp_file;
            }
            if (File.Exists(fname))
                File.Delete(fname);

            int linesWritten = 0;
            int linesOld = 0; // lines from old file
            int linesNew = 0; // lines added from this generation process

            using (System.IO.StreamWriter output_file = new System.IO.StreamWriter(fname))
            {
                // handle the old codes
                if (String.IsNullOrEmpty(source_old_codes))
                {
                    // no old codes, write the header of the file:
                    output_file.WriteLine("//qr_code,serial_number,page_number,software_version,generation_timestamp");
                }
                else
                {
                    // we have old codes, copy them
                    foreach (string line in File.ReadLines(source_old_codes))
                    {
                        linesWritten++;
                        linesOld++;
                        output_file.WriteLine(line);
                    }
                }

                // and now, handle the new codes:
                foreach (var item in _generated_codes)
                {
                    linesWritten++;
                    linesNew++;
                    output_file.WriteLine(
                            String.Format("{0},{1},{2},{3},{4}",
                                item.Item1,
                                SerialNumber.Generate(item.Item1),
                                item.Item2,
                                Application.ProductVersion,
                                DateTime.Now.ToLocalTime()
                            )
                        );                    
                }
            }

            export_lbl_report.Text =
                String.Format(
                    "Written {0} lines, imported {1}, added {2}\n" +
                    //"Max QR Code used: {3}\n" +
                    "Max page number used: {3}",
                    linesWritten, linesOld, linesNew,
                    //_max_qr_used,
                    _max_page_number_used);
        }
        #endregion

        private void stepWizardControl1_Cancelling(object sender, CancelEventArgs e)
        {
            if (worker.IsBusy)
            {
                worker.CancelAsync();
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }

        private void gen_btn_abort_Click(object sender, EventArgs e)
        {
            if (worker.IsBusy)
            {
                worker.CancelAsync();
                gen_btn_abort.Enabled = false;
            }
        }

        private void stepWizardControl1_Finished(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            config_lbl_output_dir.Text = textBoxConfigure.Text;
            _output_dir = textBoxConfigure.Text;

            page_configure.AllowNext = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _csv_filename = textBoxImport.Text;
            import_lbl_file.Text = _csv_filename;

            // the file has changed, don't go to the next page yet, first import must happen
            page_import.AllowNext = false;
            import_lbl_report.Text = String.Empty;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxConfigure_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
