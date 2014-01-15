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
            this.stepWizardControl1 = new AeroWizard.StepWizardControl();
            this.page_welcome = new AeroWizard.WizardPage();
            this.lbl_welcome_welcome = new System.Windows.Forms.Label();
            this.page_import = new AeroWizard.WizardPage();
            this.import_panel_import = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxImport = new System.Windows.Forms.TextBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxConfigure = new System.Windows.Forms.TextBox();
            this.config_btn = new System.Windows.Forms.Button();
            this.config_lbl_output_dir = new System.Windows.Forms.Label();
            this.config_lbl_3 = new System.Windows.Forms.Label();
            this.config_lbl_2 = new System.Windows.Forms.Label();
            this.config_lbl_num_qr_per_page = new System.Windows.Forms.Label();
            this.config_lbl_1 = new System.Windows.Forms.Label();
            this.config_lbl_intro = new System.Windows.Forms.Label();
            this.config_pagescount = new System.Windows.Forms.NumericUpDown();
            this.page_generate = new AeroWizard.WizardPage();
            this.gen_btn_abort = new System.Windows.Forms.Button();
            this.gen_lbl_generatedPages = new System.Windows.Forms.Label();
            this.gen_lbl_generatedQR = new System.Windows.Forms.Label();
            this.gen_tb_msg = new System.Windows.Forms.TextBox();
            this.gen_lbl_3 = new System.Windows.Forms.Label();
            this.gen_pb = new System.Windows.Forms.ProgressBar();
            this.gen_lbl_2 = new System.Windows.Forms.Label();
            this.gen_lbl_1 = new System.Windows.Forms.Label();
            this.page_export = new AeroWizard.WizardPage();
            this.radioButtonDontExport = new System.Windows.Forms.RadioButton();
            this.radioButtonDoExport = new System.Windows.Forms.RadioButton();
            this.panelDoExport = new System.Windows.Forms.Panel();
            this.textBoxExport = new System.Windows.Forms.TextBox();
            this.export_lbl_report = new System.Windows.Forms.Label();
            this.export_btn = new System.Windows.Forms.Button();
            this.export_lbl_intro = new System.Windows.Forms.Label();
            this.page_summary = new AeroWizard.WizardPage();
            this.done_lbl_dummy_label_to_get_focus = new System.Windows.Forms.Label();
            this.done_tb_msg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.stepWizardControl1)).BeginInit();
            this.page_welcome.SuspendLayout();
            this.page_import.SuspendLayout();
            this.import_panel_import.SuspendLayout();
            this.page_configure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.config_pagescount)).BeginInit();
            this.page_generate.SuspendLayout();
            this.page_export.SuspendLayout();
            this.panelDoExport.SuspendLayout();
            this.page_summary.SuspendLayout();
            this.SuspendLayout();
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
            this.stepWizardControl1.Title = "Pixformance Membership Tag Generator";
            this.stepWizardControl1.Cancelling += new System.ComponentModel.CancelEventHandler(this.stepWizardControl1_Cancelling);
            this.stepWizardControl1.Finished += new System.EventHandler(this.stepWizardControl1_Finished);
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
            this.page_import.Size = new System.Drawing.Size(401, 258);
            this.page_import.TabIndex = 4;
            this.page_import.Text = "Import";
            // 
            // import_panel_import
            // 
            this.import_panel_import.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.import_panel_import.Controls.Add(this.button2);
            this.import_panel_import.Controls.Add(this.textBoxImport);
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
            this.import_panel_import.Size = new System.Drawing.Size(372, 242);
            this.import_panel_import.TabIndex = 5;
            this.import_panel_import.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(463, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Set";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxImport
            // 
            this.textBoxImport.Location = new System.Drawing.Point(198, 30);
            this.textBoxImport.Name = "textBoxImport";
            this.textBoxImport.Size = new System.Drawing.Size(259, 23);
            this.textBoxImport.TabIndex = 10;
            this.textBoxImport.Text = "x:\\tools.QRGENERATOR\\QR-DB\\generated.csv";
            // 
            // import_lbl_report
            // 
            this.import_lbl_report.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.import_lbl_report.BackColor = System.Drawing.SystemColors.Window;
            this.import_lbl_report.ForeColor = System.Drawing.SystemColors.GrayText;
            this.import_lbl_report.Location = new System.Drawing.Point(22, 180);
            this.import_lbl_report.Name = "import_lbl_report";
            this.import_lbl_report.Size = new System.Drawing.Size(347, 53);
            this.import_lbl_report.TabIndex = 9;
            // 
            // import_lbl_file
            // 
            this.import_lbl_file.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.import_lbl_file.ForeColor = System.Drawing.SystemColors.GrayText;
            this.import_lbl_file.Location = new System.Drawing.Point(98, 66);
            this.import_lbl_file.Name = "import_lbl_file";
            this.import_lbl_file.Size = new System.Drawing.Size(267, 52);
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
            this.import_btn_import.Click += new System.EventHandler(this.import_btn_import_Click);
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
            this.import_btn_select_csv.Visible = false;
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
            this.import_lb_intro.Size = new System.Drawing.Size(401, 55);
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
            this.page_configure.AllowNext = false;
            this.page_configure.Controls.Add(this.button1);
            this.page_configure.Controls.Add(this.textBoxConfigure);
            this.page_configure.Controls.Add(this.config_btn);
            this.page_configure.Controls.Add(this.config_lbl_output_dir);
            this.page_configure.Controls.Add(this.config_lbl_3);
            this.page_configure.Controls.Add(this.config_lbl_2);
            this.page_configure.Controls.Add(this.config_lbl_num_qr_per_page);
            this.page_configure.Controls.Add(this.config_lbl_1);
            this.page_configure.Controls.Add(this.config_lbl_intro);
            this.page_configure.Controls.Add(this.config_pagescount);
            this.page_configure.Name = "page_configure";
            this.page_configure.Size = new System.Drawing.Size(401, 258);
            this.page_configure.TabIndex = 5;
            this.page_configure.Text = "Configure";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxConfigure
            // 
            this.textBoxConfigure.Location = new System.Drawing.Point(16, 270);
            this.textBoxConfigure.Name = "textBoxConfigure";
            this.textBoxConfigure.Size = new System.Drawing.Size(235, 23);
            this.textBoxConfigure.TabIndex = 8;
            this.textBoxConfigure.Text = "x:\\tools.QRGENERATOR\\QR-DB";
            this.textBoxConfigure.TextChanged += new System.EventHandler(this.textBoxConfigure_TextChanged);
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
            this.config_btn.Visible = false;
            this.config_btn.Click += new System.EventHandler(this.config_btn_Click);
            // 
            // config_lbl_output_dir
            // 
            this.config_lbl_output_dir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.config_lbl_output_dir.ForeColor = System.Drawing.SystemColors.GrayText;
            this.config_lbl_output_dir.Location = new System.Drawing.Point(118, 334);
            this.config_lbl_output_dir.Name = "config_lbl_output_dir";
            this.config_lbl_output_dir.Size = new System.Drawing.Size(276, 47);
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
            this.config_lbl_intro.Size = new System.Drawing.Size(401, 94);
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
            this.config_pagescount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.config_pagescount.Name = "config_pagescount";
            this.config_pagescount.Size = new System.Drawing.Size(120, 23);
            this.config_pagescount.TabIndex = 0;
            this.config_pagescount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // page_generate
            // 
            this.page_generate.AllowNext = false;
            this.page_generate.Controls.Add(this.gen_btn_abort);
            this.page_generate.Controls.Add(this.gen_lbl_generatedPages);
            this.page_generate.Controls.Add(this.gen_lbl_generatedQR);
            this.page_generate.Controls.Add(this.gen_tb_msg);
            this.page_generate.Controls.Add(this.gen_lbl_3);
            this.page_generate.Controls.Add(this.gen_pb);
            this.page_generate.Controls.Add(this.gen_lbl_2);
            this.page_generate.Controls.Add(this.gen_lbl_1);
            this.page_generate.Name = "page_generate";
            this.page_generate.Size = new System.Drawing.Size(401, 258);
            this.page_generate.TabIndex = 6;
            this.page_generate.Text = "Generate";
            // 
            // gen_btn_abort
            // 
            this.gen_btn_abort.AutoSize = true;
            this.gen_btn_abort.Location = new System.Drawing.Point(16, 380);
            this.gen_btn_abort.Name = "gen_btn_abort";
            this.gen_btn_abort.Size = new System.Drawing.Size(204, 25);
            this.gen_btn_abort.TabIndex = 7;
            this.gen_btn_abort.Text = "Abort after the next generated page";
            this.gen_btn_abort.UseVisualStyleBackColor = true;
            this.gen_btn_abort.Click += new System.EventHandler(this.gen_btn_abort_Click);
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
            // gen_lbl_generatedQR
            // 
            this.gen_lbl_generatedQR.AutoSize = true;
            this.gen_lbl_generatedQR.Location = new System.Drawing.Point(145, 30);
            this.gen_lbl_generatedQR.Name = "gen_lbl_generatedQR";
            this.gen_lbl_generatedQR.Size = new System.Drawing.Size(13, 15);
            this.gen_lbl_generatedQR.TabIndex = 5;
            this.gen_lbl_generatedQR.Text = "0";
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
            this.gen_tb_msg.Size = new System.Drawing.Size(558, 213);
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
            // gen_pb
            // 
            this.gen_pb.Location = new System.Drawing.Point(16, 103);
            this.gen_pb.Name = "gen_pb";
            this.gen_pb.Size = new System.Drawing.Size(548, 14);
            this.gen_pb.TabIndex = 2;
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
            // page_export
            // 
            this.page_export.AllowNext = false;
            this.page_export.Controls.Add(this.radioButtonDontExport);
            this.page_export.Controls.Add(this.radioButtonDoExport);
            this.page_export.Controls.Add(this.panelDoExport);
            this.page_export.Controls.Add(this.export_lbl_intro);
            this.page_export.Name = "page_export";
            this.page_export.Size = new System.Drawing.Size(401, 258);
            this.page_export.TabIndex = 7;
            this.page_export.Text = "Export";
            // 
            // radioButtonDontExport
            // 
            this.radioButtonDontExport.AutoSize = true;
            this.radioButtonDontExport.Location = new System.Drawing.Point(13, 268);
            this.radioButtonDontExport.Name = "radioButtonDontExport";
            this.radioButtonDontExport.Size = new System.Drawing.Size(97, 19);
            this.radioButtonDontExport.TabIndex = 2;
            this.radioButtonDontExport.TabStop = true;
            this.radioButtonDontExport.Text = "Do not export";
            this.radioButtonDontExport.UseVisualStyleBackColor = true;
            this.radioButtonDontExport.CheckedChanged += new System.EventHandler(this.radioButtonDontExport_CheckedChanged);
            // 
            // radioButtonDoExport
            // 
            this.radioButtonDoExport.AutoSize = true;
            this.radioButtonDoExport.Location = new System.Drawing.Point(13, 45);
            this.radioButtonDoExport.Name = "radioButtonDoExport";
            this.radioButtonDoExport.Size = new System.Drawing.Size(167, 19);
            this.radioButtonDoExport.TabIndex = 1;
            this.radioButtonDoExport.TabStop = true;
            this.radioButtonDoExport.Text = "Export generated QR codes";
            this.radioButtonDoExport.UseVisualStyleBackColor = true;
            this.radioButtonDoExport.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panelDoExport
            // 
            this.panelDoExport.Controls.Add(this.textBoxExport);
            this.panelDoExport.Controls.Add(this.export_lbl_report);
            this.panelDoExport.Controls.Add(this.export_btn);
            this.panelDoExport.Enabled = false;
            this.panelDoExport.Location = new System.Drawing.Point(7, 83);
            this.panelDoExport.Name = "panelDoExport";
            this.panelDoExport.Size = new System.Drawing.Size(579, 124);
            this.panelDoExport.TabIndex = 1;
            this.panelDoExport.Visible = false;
            // 
            // textBoxExport
            // 
            this.textBoxExport.Location = new System.Drawing.Point(31, 9);
            this.textBoxExport.Name = "textBoxExport";
            this.textBoxExport.Size = new System.Drawing.Size(334, 23);
            this.textBoxExport.TabIndex = 3;
            this.textBoxExport.Text = "x:\\tools.QRGENERATOR\\QR-DB\\generated.csv";
            this.textBoxExport.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // export_lbl_report
            // 
            this.export_lbl_report.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.export_lbl_report.ForeColor = System.Drawing.SystemColors.GrayText;
            this.export_lbl_report.Location = new System.Drawing.Point(3, 50);
            this.export_lbl_report.Name = "export_lbl_report";
            this.export_lbl_report.Size = new System.Drawing.Size(569, 62);
            this.export_lbl_report.TabIndex = 2;
            this.export_lbl_report.Click += new System.EventHandler(this.export_lbl_report_Click);
            // 
            // export_btn
            // 
            this.export_btn.AutoSize = true;
            this.export_btn.Location = new System.Drawing.Point(360, 7);
            this.export_btn.Name = "export_btn";
            this.export_btn.Size = new System.Drawing.Size(212, 25);
            this.export_btn.TabIndex = 1;
            this.export_btn.Text = "Export generated QR Codes to a file...";
            this.export_btn.UseVisualStyleBackColor = true;
            this.export_btn.Click += new System.EventHandler(this.export_btn_Click);
            // 
            // export_lbl_intro
            // 
            this.export_lbl_intro.Dock = System.Windows.Forms.DockStyle.Top;
            this.export_lbl_intro.Location = new System.Drawing.Point(0, 0);
            this.export_lbl_intro.Name = "export_lbl_intro";
            this.export_lbl_intro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.export_lbl_intro.Size = new System.Drawing.Size(401, 62);
            this.export_lbl_intro.TabIndex = 0;
            this.export_lbl_intro.Text = "You should export the generated QR Codes to a file and keep track of them in orde" +
    "r to avoid name collisions in the future. You should also make this file availab" +
    "le to the Platform Team.";
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
            // done_lbl_dummy_label_to_get_focus
            // 
            this.done_lbl_dummy_label_to_get_focus.AutoSize = true;
            this.done_lbl_dummy_label_to_get_focus.Location = new System.Drawing.Point(4, 4);
            this.done_lbl_dummy_label_to_get_focus.Name = "done_lbl_dummy_label_to_get_focus";
            this.done_lbl_dummy_label_to_get_focus.Size = new System.Drawing.Size(0, 15);
            this.done_lbl_dummy_label_to_get_focus.TabIndex = 0;
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
            this.done_tb_msg.Size = new System.Drawing.Size(540, 400);
            this.done_tb_msg.TabIndex = 100;
            this.done_tb_msg.TabStop = false;
            this.done_tb_msg.Text = "QR Code generation complete.";
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
            this.page_export.ResumeLayout(false);
            this.page_export.PerformLayout();
            this.panelDoExport.ResumeLayout(false);
            this.panelDoExport.PerformLayout();
            this.page_summary.ResumeLayout(false);
            this.page_summary.PerformLayout();
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
        private System.Windows.Forms.ProgressBar gen_pb;
        private System.Windows.Forms.Label gen_lbl_2;
        private System.Windows.Forms.Label gen_lbl_1;
        private System.Windows.Forms.TextBox done_tb_msg;
        private AeroWizard.WizardPage page_export;
        private System.Windows.Forms.Label done_lbl_dummy_label_to_get_focus;
        private System.Windows.Forms.Button export_btn;
        private System.Windows.Forms.Label export_lbl_intro;
        private System.Windows.Forms.Label gen_lbl_generatedPages;
        private System.Windows.Forms.Label gen_lbl_generatedQR;
        private System.Windows.Forms.Button gen_btn_abort;
        private System.Windows.Forms.Label export_lbl_report;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxConfigure;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxImport;
        private System.Windows.Forms.TextBox textBoxExport;
        private System.Windows.Forms.Panel panelDoExport;
        private System.Windows.Forms.RadioButton radioButtonDoExport;
        private System.Windows.Forms.RadioButton radioButtonDontExport;
    }
}

