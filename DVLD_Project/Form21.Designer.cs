namespace DVLD_Project
{
    partial class Form21
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
            this.licensInformations1 = new DVLD_Project.LicensInformations();
            this.SuspendLayout();
            // 
            // licensInformations1
            // 
            this.licensInformations1.Location = new System.Drawing.Point(31, 38);
            this.licensInformations1.Name = "licensInformations1";
            this.licensInformations1.Size = new System.Drawing.Size(739, 503);
            this.licensInformations1.TabIndex = 0;
            this.licensInformations1.Load += new System.EventHandler(this.licensInformations1_Load);
            // 
            // Form21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.licensInformations1);
            this.Name = "Form21";
            this.Text = "Form21";
            this.Load += new System.EventHandler(this.Form21_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LicensInformations licensInformations1;
    }
}