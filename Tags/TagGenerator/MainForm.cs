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
        string _csv_filename;

        public MainForm()
        {
            InitializeComponent();

            //// configure pages of our wizard

            // 1. Welcome

            // 2. 

            page_import.Commit += delegate(object sender, AeroWizard.WizardPageConfirmEventArgs e)
                                      { _csv_filename = dlg_open_csv.FileName; } ;

            //page_analyse_csv.Initialize += delegate(object sender, AeroWizard.WizardPageInitEventArgs e)
            //                               { bg_csv_analyse.RunWorkerAsync(); }; 
        }

        void page_analyse_csv_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btn_select_csv_Click(object sender, EventArgs e)
        {
            DialogResult dr = dlg_open_csv.ShowDialog();
            if (dr == DialogResult.OK)
            {
                stepWizardControl1.SelectedPage.AllowNext = true;
                
                _csv_filename = dlg_open_csv.FileName; 
                
                lbl_file_csv.Text = _csv_filename;
                
            }
        }

        private void bg_csv_analyse_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //pb_csv.Value = e.ProgressPercentage;
        }

        private void bg_csv_analyse_DoWork(object sender, DoWorkEventArgs e)
        {
            if (String.IsNullOrEmpty(_csv_filename))
                return;

            // the result we are looking for
            int max_qr_code = 0;

            // progress report
            long fileSize = new FileInfo(_csv_filename).Length;
            long currentPosition = 0;
            int progress = 0;

            // prepare for the callbacks to report the progress
            BackgroundWorker bw = sender as BackgroundWorker;


            char[] separators = new char[] { ',' };

            // please note: this is an iterator, it does not load the entire
            // file and we don't know the exact count of lines, so there is no progress
            // to display. If you wanted to add progress here, the easiest way
            // would be to approximate it: get the file size, and when reading lines
            // add the length of the line to a local variable. you'll miss some
            // line breaks etc, but it will be pretty close to the real progress
            foreach (string line in File.ReadLines(_csv_filename))
            {

                string[] parts = line.Split(separators);
                try
                {
                    max_qr_code = Math.Max(max_qr_code, Convert.ToInt32(parts[1]));
                }
                catch { }

                // track progress
                currentPosition += line.Length;
                int hiresProgress = (int)(100 * currentPosition / fileSize);

                if (hiresProgress != progress)
                {
                    hiresProgress = Math.Max(100, hiresProgress); // just to avoid some odd issues
                    progress = hiresProgress;
                    bw.ReportProgress(progress);
                }
            }

            e.Result = max_qr_code;
        }

        private void bg_csv_analyse_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(e.Result.ToString());
        }
    }
}
