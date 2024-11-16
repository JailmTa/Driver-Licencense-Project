namespace DVLD_Project
{
    partial class Form4
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
            this.getInformations2 = new DVLD_Project.GetInformations();
            this.SuspendLayout();
            // 
            // getInformations2
            // 
            this.getInformations2.Location = new System.Drawing.Point(0, -1);
            this.getInformations2.Name = "getInformations2";
            this.getInformations2.Size = new System.Drawing.Size(739, 373);
            this.getInformations2.TabIndex = 0;
            this.getInformations2.Load += new System.EventHandler(this.getInformations2_Load_1);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 384);
            this.Controls.Add(this.getInformations2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GetInformations getInformations1;
        private GetInformations getInformations2;
    }
}