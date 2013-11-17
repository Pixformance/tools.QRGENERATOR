namespace TagGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dlg_open_csv = new System.Windows.Forms.OpenFileDialog();
            this.bg_csv_analyse = new System.ComponentModel.BackgroundWorker();
            this.stepWizardControl1 = new AeroWizard.StepWizardControl();
            this.page_welcome = new AeroWizard.WizardPage();
            this.lbl_welcome_welcome = new System.Windows.Forms.Label();
            this.page_import = new AeroWizard.WizardPage();
            this.lbl_file_csv = new System.Windows.Forms.Label();
            this.btn_select_csv = new System.Windows.Forms.Button();
            this.page_summary = new AeroWizard.WizardPage();
            this.page_configure = new AeroWizard.WizardPage();
            this.page_generate = new AeroWizard.WizardPage();
            this.page_export = new AeroWizard.WizardPage();
            this.import_rb_import = new System.Windows.Forms.RadioButton();
            this.import_rb_dontimport = new System.Windows.Forms.RadioButton();
            this.import_lb_intro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stepWizardControl1)).BeginInit();
            this.page_welcome.SuspendLayout();
            this.page_import.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlg_open_csv
            // 
            this.dlg_open_csv.Filter = "CSV files|*.csv|All files|*.*";
            // 
            // bg_csv_analyse
            // 
            this.bg_csv_analyse.WorkerReportsProgress = true;
            this.bg_csv_analyse.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_csv_analyse_DoWork);
            this.bg_csv_analyse.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bg_csv_analyse_ProgressChanged);
            this.bg_csv_analyse.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bg_csv_analyse_RunWorkerCompleted);
            // 
            // stepWizardControl1
            // 
            this.stepWizardControl1.Location = new System.Drawing.Point(0, 0);
            this.stepWizardControl1.Name = "stepWizardControl1";
            this.stepWizardControl1.Pages.Add(this.page_welcome);
            this.stepWizardControl1.Pages.Add(this.page_import);
            this.stepWizardControl1.Pages.Add(this.page_configure);
            this.stepWizardControl1.Pages.Add(this.page_generate);
            this.stepWizardControl1.Pages.Add(this.page_export);
            this.stepWizardControl1.Pages.Add(this.page_summary);
            this.stepWizardControl1.Size = new System.Drawing.Size(784, 561);
            this.stepWizardControl1.TabIndex = 0;
            // 
            // page_welcome
            // 
            this.page_welcome.Controls.Add(this.lbl_welcome_welcome);
            this.page_welcome.Name = "page_welcome";
            this.page_welcome.Size = new System.Drawing.Size(586, 406);
            this.page_welcome.TabIndex = 2;
            this.page_welcome.Text = "Welcome";
            // 
            // lbl_welcome_welcome
            // 
            this.lbl_welcome_welcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_welcome_welcome.Location = new System.Drawing.Point(0, 0);
            this.lbl_welcome_welcome.Name = "lbl_welcome_welcome";
            this.lbl_welcome_welcome.Size = new System.Drawing.Size(586, 406);
            this.lbl_welcome_welcome.TabIndex = 0;
            this.lbl_welcome_welcome.Text = resources.GetString("lbl_welcome_welcome.Text");
            // 
            // page_import
            // 
            this.page_import.AllowNext = false;
            this.page_import.Controls.Add(this.import_lb_intro);
            this.page_import.Controls.Add(this.import_rb_dontimport);
            this.page_import.Controls.Add(this.import_rb_import);
            this.page_import.Controls.Add(this.lbl_file_csv);
            this.page_import.Controls.Add(this.btn_select_csv);
            this.page_import.Name = "page_import";
            this.page_import.Size = new System.Drawing.Size(586, 406);
            this.page_import.TabIndex = 4;
            this.page_import.Text = "Import";
            // 
            // lbl_file_csv
            // 
            this.lbl_file_csv.AutoSize = true;
            this.lbl_file_csv.Location = new System.Drawing.Point(31, 352);
            this.lbl_file_csv.Name = "lbl_file_csv";
            this.lbl_file_csv.Size = new System.Drawing.Size(38, 15);
            this.lbl_file_csv.TabIndex = 1;
            this.lbl_file_csv.Text = "label2";
            // 
            // btn_select_csv
            // 
            this.btn_select_csv.Location = new System.Drawing.Point(117, 286);
            this.btn_select_csv.Name = "btn_select_csv";
            this.btn_select_csv.Size = new System.Drawing.Size(121, 91);
            this.btn_select_csv.TabIndex = 1;
            this.btn_select_csv.Text = "button1";
            this.btn_select_csv.UseVisualStyleBackColor = true;
            this.btn_select_csv.Click += new System.EventHandler(this.btn_select_csv_Click);
            // 
            // page_summary
            // 
            this.page_summary.IsFinishPage = true;
            this.page_summary.Name = "page_summary";
            this.page_summary.Size = new System.Drawing.Size(586, 406);
            this.page_summary.TabIndex = 3;
            this.page_summary.Text = "Done";
            // 
            // page_configure
            // 
            this.page_configure.Name = "page_configure";
            this.page_configure.Size = new System.Drawing.Size(586, 406);
            this.page_configure.TabIndex = 5;
            this.page_configure.Text = "Configure";
            // 
            // page_generate
            // 
            this.page_generate.Name = "page_generate";
            this.page_generate.Size = new System.Drawing.Size(586, 406);
            this.page_generate.TabIndex = 6;
            this.page_generate.Text = "Generate";
            // 
            // page_export
            // 
            this.page_export.Name = "page_export";
            this.page_export.Size = new System.Drawing.Size(586, 406);
            this.page_export.TabIndex = 7;
            this.page_export.Text = "Export";
            // 
            // import_rb_import
            // 
            this.import_rb_import.AutoSize = true;
            this.import_rb_import.Location = new System.Drawing.Point(4, 79);
            this.import_rb_import.Name = "import_rb_import";
            this.import_rb_import.Size = new System.Drawing.Size(172, 19);
            this.import_rb_import.TabIndex = 2;
            this.import_rb_import.TabStop = true;
            this.import_rb_import.Text = "Import generated QR Codes";
            this.import_rb_import.UseVisualStyleBackColor = true;
            // 
            // import_rb_dontimport
            // 
            this.import_rb_dontimport.AutoSize = true;
            this.import_rb_dontimport.Location = new System.Drawing.Point(4, 192);
            this.import_rb_dontimport.Name = "import_rb_dontimport";
            this.import_rb_dontimport.Size = new System.Drawing.Size(204, 19);
            this.import_rb_dontimport.TabIndex = 3;
            this.import_rb_dontimport.TabStop = true;
            this.import_rb_dontimport.Text = "Don\'t import generated QR Codes";
            this.import_rb_dontimport.UseVisualStyleBackColor = true;
            // 
            // import_lb_intro
            // 
            this.import_lb_intro.Dock = System.Windows.Forms.DockStyle.Top;
            this.import_lb_intro.Location = new System.Drawing.Point(0, 0);
            this.import_lb_intro.Name = "import_lb_intro";
            this.import_lb_intro.Size = new System.Drawing.Size(586, 48);
            this.import_lb_intro.TabIndex = 4;
            this.import_lb_intro.Text = "You have the option of importing a file with a list of QR Codes generated in the " +
    "past. Please keep track fo the generated QR Codes in order to avoid collisions i" +
    "n the future.\r\n";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.stepWizardControl1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.stepWizardControl1)).EndInit();
            this.page_welcome.ResumeLayout(false);
            this.page_import.ResumeLayout(false);
            this.page_import.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AeroWizard.StepWizardControl stepWizardControl1;
        private AeroWizard.WizardPage page_welcome;
        private AeroWizard.WizardPage page_summary;
        private System.Windows.Forms.Label lbl_welcome_welcome;
        private AeroWizard.WizardPage page_import;
        private System.Windows.Forms.Label lbl_file_csv;
        private System.Windows.Forms.Button btn_select_csv;
        private System.Windows.Forms.OpenFileDialog dlg_open_csv;
        private System.ComponentModel.BackgroundWorker bg_csv_analyse;
        private AeroWizard.WizardPage page_configure;
        private AeroWizard.WizardPage page_generate;
        private AeroWizard.WizardPage page_export;
        private System.Windows.Forms.RadioButton import_rb_dontimport;
        private System.Windows.Forms.RadioButton import_rb_import;
        private System.Windows.Forms.Label import_lb_intro;
    }
}

