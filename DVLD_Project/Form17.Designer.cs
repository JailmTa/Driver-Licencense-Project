namespace DVLD_Project
{
    partial class Form17
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
            this.getInformations1 = new DVLD_Project.GetInformations();
            this.getAppInfo1 = new DVLD_Project.GetAppInfo();
            this.SuspendLayout();
            // 
            // getInformations1
            // 
            this.getInformations1.Location = new System.Drawing.Point(13, 155);
            this.getInformations1.Name = "getInformations1";
            this.getInformations1.Size = new System.Drawing.Size(736, 373);
            this.getInformations1.TabIndex = 0;
            // 
            // getAppInfo1
            // 
            this.getAppInfo1.Location = new System.Drawing.Point(13, 61);
            this.getAppInfo1.Name = "getAppInfo1";
            this.getAppInfo1.Size = new System.Drawing.Size(736, 152);
            this.getAppInfo1.TabIndex = 1;
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 530);
            this.Controls.Add(this.getAppInfo1);
            this.Controls.Add(this.getInformations1);
            this.Name = "Form17";
            this.Text = "Form17";
            this.Load += new System.EventHandler(this.Form17_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GetInformations getInformations1;
        private GetAppInfo getAppInfo1;
    }
}