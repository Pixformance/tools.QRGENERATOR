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
            this.stepWizardControl1 = new AeroWizard.StepWizardControl();
            this.page_welcome = new AeroWizard.WizardPage();
            this.page_done = new AeroWizard.WizardPage();
            ((System.ComponentModel.ISupportInitialize)(this.stepWizardControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // stepWizardControl1
            // 
            this.stepWizardControl1.Location = new System.Drawing.Point(0, 0);
            this.stepWizardControl1.Name = "stepWizardControl1";
            this.stepWizardControl1.Pages.Add(this.page_welcome);
            this.stepWizardControl1.Pages.Add(this.page_done);
            this.stepWizardControl1.Size = new System.Drawing.Size(781, 407);
            this.stepWizardControl1.TabIndex = 0;
            // 
            // page_welcome
            // 
            this.page_welcome.Name = "page_welcome";
            this.page_welcome.Size = new System.Drawing.Size(583, 252);
            this.page_welcome.TabIndex = 2;
            this.page_welcome.Text = "Welcome";
            // 
            // page_done
            // 
            this.page_done.IsFinishPage = true;
            this.page_done.Name = "page_done";
            this.page_done.Size = new System.Drawing.Size(583, 252);
            this.page_done.TabIndex = 3;
            this.page_done.Text = "Done";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 407);
            this.Controls.Add(this.stepWizardControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.stepWizardControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AeroWizard.StepWizardControl stepWizardControl1;
        private AeroWizard.WizardPage page_welcome;
        private AeroWizard.WizardPage page_done;
    }
}

