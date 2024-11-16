using BussnessLayerForDVLD;

namespace DVLD_Project
{
    partial class Form8
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
            this.userInfo1 = new DVLD_Project.UserInfo(clsBussnesLayer.GetUserID());
            this.SuspendLayout();
            // 
            // getInformations1
            // 
            this.getInformations1.Location = new System.Drawing.Point(81, 12);
            this.getInformations1.Name = "getInformations1";
            this.getInformations1.Size = new System.Drawing.Size(739, 373);
            this.getInformations1.TabIndex = 0;
            this.getInformations1.Load += new System.EventHandler(this.getInformations1_Load);
            // 
            // userInfo1
            // 
            this.userInfo1.Location = new System.Drawing.Point(81, 381);
            this.userInfo1.Name = "userInfo1";
            this.userInfo1.Size = new System.Drawing.Size(739, 91);
            this.userInfo1.TabIndex = 1;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 528);
            this.Controls.Add(this.userInfo1);
            this.Controls.Add(this.getInformations1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GetInformations getInformations1;
        private UserInfo userInfo1;
    }
}