﻿namespace TagGenerator
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
            this.import_panel_import = new System.Windows.Forms.Panel();
            this.import_lbl_report = new System.Windows.Forms.Label();
            this.import_lbl_file = new System.Windows.Forms.Label();
            this.import_lbl_3 = new System.Windows.Forms.Label();
            this.import_btn_import = new System.Windows.Forms.Button();
            this.import_lbl_1 = new System.Windows.Forms.Label();
            this.import_btn_select_csv = new System.Windows.Forms.Button();
            this.import_lbl_2 = new System.Windows.Forms.Label();
            this.import_lb_intro = new System.Windows.Forms.Label();
            this.import_rb_dontimport = new System.Windows.Forms.RadioButton();
            this.import_rb_import = new System.Windows.Forms.RadioButton();
            this.page_configure = new AeroWizard.WizardPage();
            this.config_btn = new System.Windows.Forms.Button();
            this.config_lbl_output_dir = new System.Windows.Forms.Label();
            this.config_lbl_3 = new System.Windows.Forms.Label();
            this.config_lbl_2 = new System.Windows.Forms.Label();
            this.config_lbl_num_qr_per_page = new System.Windows.Forms.Label();
            this.config_lbl_1 = new System.Windows.Forms.Label();
            this.config_lbl_intro = new System.Windows.Forms.Label();
            this.config_pagescount = new System.Windows.Forms.NumericUpDown();
            this.page_generate = new AeroWizard.WizardPage();
            this.gen_tb_msg = new System.Windows.Forms.TextBox();
            this.gen_lbl_3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.gen_lbl_2 = new System.Windows.Forms.Label();
            this.gen_lbl_1 = new System.Windows.Forms.Label();
            this.page_summary = new AeroWizard.WizardPage();
            this.done_tb_msg = new System.Windows.Forms.TextBox();
            this.page_export = new AeroWizard.WizardPage();
            this.done_lbl_dummy_label_to_get_focus = new System.Windows.Forms.Label();
            this.export_lbl_intro = new System.Windows.Forms.Label();
            this.export_btn = new System.Windows.Forms.Button();
            this.gen_lbl_generatedQR = new System.Windows.Forms.Label();
            this.gen_lbl_generatedPages = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stepWizardControl1)).BeginInit();
            this.page_welcome.SuspendLayout();
            this.page_import.SuspendLayout();
            this.import_panel_import.SuspendLayout();
            this.page_configure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.config_pagescount)).BeginInit();
            this.page_generate.SuspendLayout();
            this.page_summary.SuspendLayout();
            this.page_export.SuspendLayout();
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
            this.lbl_welcome_welcome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbl_welcome_welcome.Size = new System.Drawing.Size(586, 406);
            this.lbl_welcome_welcome.TabIndex = 0;
            this.lbl_welcome_welcome.Text = resources.GetString("lbl_welcome_welcome.Text");
            // 
            // page_import
            // 
            this.page_import.AllowNext = false;
            this.page_import.Controls.Add(this.import_panel_import);
            this.page_import.Controls.Add(this.import_lb_intro);
            this.page_import.Controls.Add(this.import_rb_dontimport);
            this.page_import.Controls.Add(this.import_rb_import);
            this.page_import.Name = "page_import";
            this.page_import.Size = new System.Drawing.Size(586, 406);
            this.page_import.TabIndex = 4;
            this.page_import.Text = "Import";
            // 
            // import_panel_import
            // 
            this.import_panel_import.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.import_panel_import.Controls.Add(this.import_lbl_report);
            this.import_panel_import.Controls.Add(this.import_lbl_file);
            this.import_panel_import.Controls.Add(this.import_lbl_3);
            this.import_panel_import.Controls.Add(this.import_btn_import);
            this.import_panel_import.Controls.Add(this.import_lbl_1);
            this.import_panel_import.Controls.Add(this.import_btn_select_csv);
            this.import_panel_import.Controls.Add(this.import_lbl_2);
            this.import_panel_import.Enabled = false;
            this.import_panel_import.Location = new System.Drawing.Point(26, 90);
            this.import_panel_import.Name = "import_panel_import";
            this.import_panel_import.Size = new System.Drawing.Size(557, 242);
            this.import_panel_import.TabIndex = 5;
            this.import_panel_import.Visible = false;
            // 
            // import_lbl_report
            // 
            this.import_lbl_report.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.import_lbl_report.Location = new System.Drawing.Point(22, 180);
            this.import_lbl_report.Name = "import_lbl_report";
            this.import_lbl_report.Size = new System.Drawing.Size(532, 53);
            this.import_lbl_report.TabIndex = 9;
            // 
            // import_lbl_file
            // 
            this.import_lbl_file.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.import_lbl_file.ForeColor = System.Drawing.SystemColors.GrayText;
            this.import_lbl_file.Location = new System.Drawing.Point(98, 66);
            this.import_lbl_file.Name = "import_lbl_file";
            this.import_lbl_file.Size = new System.Drawing.Size(452, 52);
            this.import_lbl_file.TabIndex = 8;
            this.import_lbl_file.Text = "<no file>";
            // 
            // import_lbl_3
            // 
            this.import_lbl_3.AutoSize = true;
            this.import_lbl_3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.import_lbl_3.Location = new System.Drawing.Point(19, 66);
            this.import_lbl_3.Name = "import_lbl_3";
            this.import_lbl_3.Size = new System.Drawing.Size(73, 15);
            this.import_lbl_3.TabIndex = 7;
            this.import_lbl_3.Text = "Selected file:";
            // 
            // import_btn_import
            // 
            this.import_btn_import.Location = new System.Drawing.Point(22, 150);
            this.import_btn_import.Name = "import_btn_import";
            this.import_btn_import.Size = new System.Drawing.Size(149, 23);
            this.import_btn_import.TabIndex = 6;
            this.import_btn_import.Text = "Import";
            this.import_btn_import.UseVisualStyleBackColor = true;
            // 
            // import_lbl_1
            // 
            this.import_lbl_1.AutoSize = true;
            this.import_lbl_1.Location = new System.Drawing.Point(3, 0);
            this.import_lbl_1.Name = "import_lbl_1";
            this.import_lbl_1.Size = new System.Drawing.Size(317, 15);
            this.import_lbl_1.TabIndex = 5;
            this.import_lbl_1.Text = "1. Select the file containing previously generated QR Codes";
            // 
            // import_btn_select_csv
            // 
            this.import_btn_select_csv.AutoSize = true;
            this.import_btn_select_csv.Location = new System.Drawing.Point(22, 30);
            this.import_btn_select_csv.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.import_btn_select_csv.Name = "import_btn_select_csv";
            this.import_btn_select_csv.Size = new System.Drawing.Size(149, 25);
            this.import_btn_select_csv.TabIndex = 4;
            this.import_btn_select_csv.Text = "Select the file to import...";
            this.import_btn_select_csv.UseVisualStyleBackColor = true;
            this.import_btn_select_csv.Click += new System.EventHandler(this.btn_select_csv_Click);
            // 
            // import_lbl_2
            // 
            this.import_lbl_2.AutoSize = true;
            this.import_lbl_2.Location = new System.Drawing.Point(3, 120);
            this.import_lbl_2.Name = "import_lbl_2";
            this.import_lbl_2.Size = new System.Drawing.Size(243, 15);
            this.import_lbl_2.TabIndex = 1;
            this.import_lbl_2.Text = "2. Import the previously generated QR Codes";
            // 
            // import_lb_intro
            // 
            this.import_lb_intro.Dock = System.Windows.Forms.DockStyle.Top;
            this.import_lb_intro.Location = new System.Drawing.Point(0, 0);
            this.import_lb_intro.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.import_lb_intro.Name = "import_lb_intro";
            this.import_lb_intro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.import_lb_intro.Size = new System.Drawing.Size(586, 55);
            this.import_lb_intro.TabIndex = 1;
            this.import_lb_intro.Text = "You have the option of importing a file with a list of QR Codes generated in the " +
    "past. Please keep track fo the generated QR Codes in order to avoid collisions i" +
    "n the future.\r\n";
            // 
            // import_rb_dontimport
            // 
            this.import_rb_dontimport.AutoSize = true;
            this.import_rb_dontimport.Location = new System.Drawing.Point(14, 384);
            this.import_rb_dontimport.Name = "import_rb_dontimport";
            this.import_rb_dontimport.Size = new System.Drawing.Size(93, 19);
            this.import_rb_dontimport.TabIndex = 3;
            this.import_rb_dontimport.TabStop = true;
            this.import_rb_dontimport.Text = "Don\'t import";
            this.import_rb_dontimport.UseVisualStyleBackColor = true;
            this.import_rb_dontimport.CheckedChanged += new System.EventHandler(this.import_rb_dontimport_CheckedChanged);
            // 
            // import_rb_import
            // 
            this.import_rb_import.AutoSize = true;
            this.import_rb_import.Location = new System.Drawing.Point(14, 60);
            this.import_rb_import.Name = "import_rb_import";
            this.import_rb_import.Size = new System.Drawing.Size(172, 19);
            this.import_rb_import.TabIndex = 2;
            this.import_rb_import.TabStop = true;
            this.import_rb_import.Text = "Import generated QR Codes";
            this.import_rb_import.UseVisualStyleBackColor = true;
            this.import_rb_import.CheckedChanged += new System.EventHandler(this.import_rb_import_CheckedChanged);
            // 
            // page_configure
            // 
            this.page_configure.Controls.Add(this.config_btn);
            this.page_configure.Controls.Add(this.config_lbl_output_dir);
            this.page_configure.Controls.Add(this.config_lbl_3);
            this.page_configure.Controls.Add(this.config_lbl_2);
            this.page_configure.Controls.Add(this.config_lbl_num_qr_per_page);
            this.page_configure.Controls.Add(this.config_lbl_1);
            this.page_configure.Controls.Add(this.config_lbl_intro);
            this.page_configure.Controls.Add(this.config_pagescount);
            this.page_configure.Name = "page_configure";
            this.page_configure.Size = new System.Drawing.Size(586, 406);
            this.page_configure.TabIndex = 5;
            this.page_configure.Text = "Configure";
            // 
            // config_btn
            // 
            this.config_btn.AutoSize = true;
            this.config_btn.Location = new System.Drawing.Point(16, 296);
            this.config_btn.Name = "config_btn";
            this.config_btn.Size = new System.Drawing.Size(166, 25);
            this.config_btn.TabIndex = 7;
            this.config_btn.Text = "Select the output directory...";
            this.config_btn.UseVisualStyleBackColor = true;
            // 
            // config_lbl_output_dir
            // 
            this.config_lbl_output_dir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.config_lbl_output_dir.ForeColor = System.Drawing.SystemColors.GrayText;
            this.config_lbl_output_dir.Location = new System.Drawing.Point(118, 334);
            this.config_lbl_output_dir.Name = "config_lbl_output_dir";
            this.config_lbl_output_dir.Size = new System.Drawing.Size(461, 47);
            this.config_lbl_output_dir.TabIndex = 6;
            this.config_lbl_output_dir.Text = "<no directory>";
            // 
            // config_lbl_3
            // 
            this.config_lbl_3.AutoSize = true;
            this.config_lbl_3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.config_lbl_3.Location = new System.Drawing.Point(13, 334);
            this.config_lbl_3.Name = "config_lbl_3";
            this.config_lbl_3.Size = new System.Drawing.Size(98, 15);
            this.config_lbl_3.TabIndex = 5;
            this.config_lbl_3.Text = "Output directory:";
            // 
            // config_lbl_2
            // 
            this.config_lbl_2.AutoSize = true;
            this.config_lbl_2.Location = new System.Drawing.Point(13, 110);
            this.config_lbl_2.Name = "config_lbl_2";
            this.config_lbl_2.Size = new System.Drawing.Size(215, 15);
            this.config_lbl_2.TabIndex = 4;
            this.config_lbl_2.Text = "Number of QR Code pages to generate:";
            // 
            // config_lbl_num_qr_per_page
            // 
            this.config_lbl_num_qr_per_page.AutoSize = true;
            this.config_lbl_num_qr_per_page.ForeColor = System.Drawing.SystemColors.GrayText;
            this.config_lbl_num_qr_per_page.Location = new System.Drawing.Point(192, 167);
            this.config_lbl_num_qr_per_page.Name = "config_lbl_num_qr_per_page";
            this.config_lbl_num_qr_per_page.Size = new System.Drawing.Size(59, 15);
            this.config_lbl_num_qr_per_page.TabIndex = 3;
            this.config_lbl_num_qr_per_page.Text = "<not set>";
            // 
            // config_lbl_1
            // 
            this.config_lbl_1.AutoSize = true;
            this.config_lbl_1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.config_lbl_1.Location = new System.Drawing.Point(13, 167);
            this.config_lbl_1.Name = "config_lbl_1";
            this.config_lbl_1.Size = new System.Drawing.Size(172, 15);
            this.config_lbl_1.TabIndex = 2;
            this.config_lbl_1.Text = "Number of QR Codes per page:";
            // 
            // config_lbl_intro
            // 
            this.config_lbl_intro.Dock = System.Windows.Forms.DockStyle.Top;
            this.config_lbl_intro.Location = new System.Drawing.Point(0, 0);
            this.config_lbl_intro.Name = "config_lbl_intro";
            this.config_lbl_intro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.config_lbl_intro.Size = new System.Drawing.Size(586, 94);
            this.config_lbl_intro.TabIndex = 1;
            this.config_lbl_intro.Text = resources.GetString("config_lbl_intro.Text");
            // 
            // config_pagescount
            // 
            this.config_pagescount.Location = new System.Drawing.Point(16, 130);
            this.config_pagescount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.config_pagescount.Name = "config_pagescount";
            this.config_pagescount.Size = new System.Drawing.Size(120, 23);
            this.config_pagescount.TabIndex = 0;
            // 
            // page_generate
            // 
            this.page_generate.Controls.Add(this.gen_lbl_generatedPages);
            this.page_generate.Controls.Add(this.gen_lbl_generatedQR);
            this.page_generate.Controls.Add(this.gen_tb_msg);
            this.page_generate.Controls.Add(this.gen_lbl_3);
            this.page_generate.Controls.Add(this.progressBar1);
            this.page_generate.Controls.Add(this.gen_lbl_2);
            this.page_generate.Controls.Add(this.gen_lbl_1);
            this.page_generate.Name = "page_generate";
            this.page_generate.Size = new System.Drawing.Size(586, 406);
            this.page_generate.TabIndex = 6;
            this.page_generate.Text = "Generate";
            // 
            // gen_tb_msg
            // 
            this.gen_tb_msg.BackColor = System.Drawing.SystemColors.Window;
            this.gen_tb_msg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gen_tb_msg.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gen_tb_msg.Location = new System.Drawing.Point(13, 161);
            this.gen_tb_msg.Multiline = true;
            this.gen_tb_msg.Name = "gen_tb_msg";
            this.gen_tb_msg.ReadOnly = true;
            this.gen_tb_msg.Size = new System.Drawing.Size(558, 242);
            this.gen_tb_msg.TabIndex = 4;
            // 
            // gen_lbl_3
            // 
            this.gen_lbl_3.AutoSize = true;
            this.gen_lbl_3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gen_lbl_3.Location = new System.Drawing.Point(13, 143);
            this.gen_lbl_3.Name = "gen_lbl_3";
            this.gen_lbl_3.Size = new System.Drawing.Size(61, 15);
            this.gen_lbl_3.TabIndex = 3;
            this.gen_lbl_3.Text = "Messages:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 103);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(548, 14);
            this.progressBar1.TabIndex = 2;
            // 
            // gen_lbl_2
            // 
            this.gen_lbl_2.AutoSize = true;
            this.gen_lbl_2.Location = new System.Drawing.Point(13, 67);
            this.gen_lbl_2.Name = "gen_lbl_2";
            this.gen_lbl_2.Size = new System.Drawing.Size(122, 15);
            this.gen_lbl_2.TabIndex = 1;
            this.gen_lbl_2.Text = "Generated PDF pages:";
            // 
            // gen_lbl_1
            // 
            this.gen_lbl_1.AutoSize = true;
            this.gen_lbl_1.Location = new System.Drawing.Point(13, 30);
            this.gen_lbl_1.Name = "gen_lbl_1";
            this.gen_lbl_1.Size = new System.Drawing.Size(119, 15);
            this.gen_lbl_1.TabIndex = 0;
            this.gen_lbl_1.Text = "Generated QR Codes:";
            // 
            // page_summary
            // 
            this.page_summary.Controls.Add(this.done_lbl_dummy_label_to_get_focus);
            this.page_summary.Controls.Add(this.done_tb_msg);
            this.page_summary.IsFinishPage = true;
            this.page_summary.Name = "page_summary";
            this.page_summary.Size = new System.Drawing.Size(586, 406);
            this.page_summary.TabIndex = 3;
            this.page_summary.Text = "Done";
            // 
            // done_tb_msg
            // 
            this.done_tb_msg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.done_tb_msg.BackColor = System.Drawing.SystemColors.Window;
            this.done_tb_msg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.done_tb_msg.ForeColor = System.Drawing.SystemColors.GrayText;
            this.done_tb_msg.Location = new System.Drawing.Point(13, 3);
            this.done_tb_msg.Multiline = true;
            this.done_tb_msg.Name = "done_tb_msg";
            this.done_tb_msg.ReadOnly = true;
            this.done_tb_msg.Size = new System.Drawing.Size(573, 403);
            this.done_tb_msg.TabIndex = 100;
            this.done_tb_msg.TabStop = false;
            this.done_tb_msg.Text = "Report:";
            // 
            // page_export
            // 
            this.page_export.Controls.Add(this.export_btn);
            this.page_export.Controls.Add(this.export_lbl_intro);
            this.page_export.Name = "page_export";
            this.page_export.Size = new System.Drawing.Size(586, 406);
            this.page_export.TabIndex = 7;
            this.page_export.Text = "Export";
            // 
            // done_lbl_dummy_label_to_get_focus
            // 
            this.done_lbl_dummy_label_to_get_focus.AutoSize = true;
            this.done_lbl_dummy_label_to_get_focus.Location = new System.Drawing.Point(4, 4);
            this.done_lbl_dummy_label_to_get_focus.Name = "done_lbl_dummy_label_to_get_focus";
            this.done_lbl_dummy_label_to_get_focus.Size = new System.Drawing.Size(0, 15);
            this.done_lbl_dummy_label_to_get_focus.TabIndex = 0;
            // 
            // export_lbl_intro
            // 
            this.export_lbl_intro.Dock = System.Windows.Forms.DockStyle.Top;
            this.export_lbl_intro.Location = new System.Drawing.Point(0, 0);
            this.export_lbl_intro.Name = "export_lbl_intro";
            this.export_lbl_intro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.export_lbl_intro.Size = new System.Drawing.Size(586, 62);
            this.export_lbl_intro.TabIndex = 0;
            this.export_lbl_intro.Text = "You should export the generated QR Codes to a file and keep track of them in orde" +
    "r to avoid name collisions in the future. You should also make this file availab" +
    "le to the Platform Team.";
            // 
            // export_btn
            // 
            this.export_btn.AutoSize = true;
            this.export_btn.Location = new System.Drawing.Point(14, 66);
            this.export_btn.Name = "export_btn";
            this.export_btn.Size = new System.Drawing.Size(212, 25);
            this.export_btn.TabIndex = 1;
            this.export_btn.Text = "Export generated QR Codes to a file...";
            this.export_btn.UseVisualStyleBackColor = true;
            // 
            // gen_lbl_generatedQR
            // 
            this.gen_lbl_generatedQR.AutoSize = true;
            this.gen_lbl_generatedQR.Location = new System.Drawing.Point(145, 30);
            this.gen_lbl_generatedQR.Name = "gen_lbl_generatedQR";
            this.gen_lbl_generatedQR.Size = new System.Drawing.Size(13, 15);
            this.gen_lbl_generatedQR.TabIndex = 5;
            this.gen_lbl_generatedQR.Text = "0";
            // 
            // gen_lbl_generatedPages
            // 
            this.gen_lbl_generatedPages.AutoSize = true;
            this.gen_lbl_generatedPages.Location = new System.Drawing.Point(145, 67);
            this.gen_lbl_generatedPages.Name = "gen_lbl_generatedPages";
            this.gen_lbl_generatedPages.Size = new System.Drawing.Size(13, 15);
            this.gen_lbl_generatedPages.TabIndex = 6;
            this.gen_lbl_generatedPages.Text = "0";
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
            this.import_panel_import.ResumeLayout(false);
            this.import_panel_import.PerformLayout();
            this.page_configure.ResumeLayout(false);
            this.page_configure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.config_pagescount)).EndInit();
            this.page_generate.ResumeLayout(false);
            this.page_generate.PerformLayout();
            this.page_summary.ResumeLayout(false);
            this.page_summary.PerformLayout();
            this.page_export.ResumeLayout(false);
            this.page_export.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AeroWizard.StepWizardControl stepWizardControl1;
        private AeroWizard.WizardPage page_welcome;
        private AeroWizard.WizardPage page_summary;
        private System.Windows.Forms.Label lbl_welcome_welcome;
        private AeroWizard.WizardPage page_import;
        private System.Windows.Forms.Label import_lbl_2;
        private System.Windows.Forms.Button import_btn_select_csv;
        private System.Windows.Forms.OpenFileDialog dlg_open_csv;
        private System.ComponentModel.BackgroundWorker bg_csv_analyse;
        private AeroWizard.WizardPage page_configure;
        private AeroWizard.WizardPage page_generate;
        private System.Windows.Forms.RadioButton import_rb_dontimport;
        private System.Windows.Forms.RadioButton import_rb_import;
        private System.Windows.Forms.Label import_lb_intro;
        private System.Windows.Forms.Panel import_panel_import;
        private System.Windows.Forms.Label import_lbl_1;
        private System.Windows.Forms.Button import_btn_import;
        private System.Windows.Forms.Label import_lbl_file;
        private System.Windows.Forms.Label import_lbl_3;
        private System.Windows.Forms.Label import_lbl_report;
        private System.Windows.Forms.Label config_lbl_num_qr_per_page;
        private System.Windows.Forms.Label config_lbl_1;
        private System.Windows.Forms.Label config_lbl_intro;
        private System.Windows.Forms.NumericUpDown config_pagescount;
        private System.Windows.Forms.Label config_lbl_2;
        private System.Windows.Forms.Button config_btn;
        private System.Windows.Forms.Label config_lbl_output_dir;
        private System.Windows.Forms.Label config_lbl_3;
        private System.Windows.Forms.TextBox gen_tb_msg;
        private System.Windows.Forms.Label gen_lbl_3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label gen_lbl_2;
        private System.Windows.Forms.Label gen_lbl_1;
        private System.Windows.Forms.TextBox done_tb_msg;
        private AeroWizard.WizardPage page_export;
        private System.Windows.Forms.Label done_lbl_dummy_label_to_get_focus;
        private System.Windows.Forms.Button export_btn;
        private System.Windows.Forms.Label export_lbl_intro;
        private System.Windows.Forms.Label gen_lbl_generatedPages;
        private System.Windows.Forms.Label gen_lbl_generatedQR;
    }
}

