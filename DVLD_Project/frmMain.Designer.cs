namespace DVLD_Project
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingLicenseServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeNewLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newLocaleLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newInternationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detiningLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maneageApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLocalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGlobalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetiningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detiningLicenseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relaseLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maneageApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maneageTestsTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showUserInformationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePassWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplaToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1902, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aplaToolStripMenuItem
            // 
            this.aplaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLicenseServerToolStripMenuItem,
            this.maneageApplicationToolStripMenuItem,
            this.detinToolStripMenuItem,
            this.maneageApplicationTypesToolStripMenuItem,
            this.maneageTestsTypesToolStripMenuItem});
            this.aplaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aplaToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_archive_64;
            this.aplaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aplaToolStripMenuItem.Name = "aplaToolStripMenuItem";
            this.aplaToolStripMenuItem.Size = new System.Drawing.Size(235, 54);
            this.aplaToolStripMenuItem.Text = "Applacations";
            // 
            // drivingLicenseServerToolStripMenuItem
            // 
            this.drivingLicenseServerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeNewLicenseToolStripMenuItem,
            this.renewLicenseToolStripMenuItem,
            this.replaceLicenseToolStripMenuItem,
            this.detiningLicenseToolStripMenuItem});
            this.drivingLicenseServerToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_add_to_clipboard_64;
            this.drivingLicenseServerToolStripMenuItem.Name = "drivingLicenseServerToolStripMenuItem";
            this.drivingLicenseServerToolStripMenuItem.Size = new System.Drawing.Size(466, 56);
            this.drivingLicenseServerToolStripMenuItem.Text = "Driving License Server";
            this.drivingLicenseServerToolStripMenuItem.Click += new System.EventHandler(this.drivingLicenseServerToolStripMenuItem_Click);
            // 
            // makeNewLicenseToolStripMenuItem
            // 
            this.makeNewLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newLocaleLicenseToolStripMenuItem,
            this.newInternationalLicenseToolStripMenuItem});
            this.makeNewLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_add_64__1_;
            this.makeNewLicenseToolStripMenuItem.Name = "makeNewLicenseToolStripMenuItem";
            this.makeNewLicenseToolStripMenuItem.Size = new System.Drawing.Size(327, 42);
            this.makeNewLicenseToolStripMenuItem.Text = "Make New License";
            // 
            // newLocaleLicenseToolStripMenuItem
            // 
            this.newLocaleLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_taxi_license_100;
            this.newLocaleLicenseToolStripMenuItem.Name = "newLocaleLicenseToolStripMenuItem";
            this.newLocaleLicenseToolStripMenuItem.Size = new System.Drawing.Size(413, 42);
            this.newLocaleLicenseToolStripMenuItem.Text = "New Locale License";
            this.newLocaleLicenseToolStripMenuItem.Click += new System.EventHandler(this.newLocaleLicenseToolStripMenuItem_Click);
            // 
            // newInternationalLicenseToolStripMenuItem
            // 
            this.newInternationalLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_passport_100;
            this.newInternationalLicenseToolStripMenuItem.Name = "newInternationalLicenseToolStripMenuItem";
            this.newInternationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(413, 42);
            this.newInternationalLicenseToolStripMenuItem.Text = "New International License";
            this.newInternationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.newInternationalLicenseToolStripMenuItem_Click);
            // 
            // renewLicenseToolStripMenuItem
            // 
            this.renewLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_swap_paths_64;
            this.renewLicenseToolStripMenuItem.Name = "renewLicenseToolStripMenuItem";
            this.renewLicenseToolStripMenuItem.Size = new System.Drawing.Size(327, 42);
            this.renewLicenseToolStripMenuItem.Text = "Renew License";
            this.renewLicenseToolStripMenuItem.Click += new System.EventHandler(this.renewLicenseToolStripMenuItem_Click);
            // 
            // replaceLicenseToolStripMenuItem
            // 
            this.replaceLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_card_exchange_64;
            this.replaceLicenseToolStripMenuItem.Name = "replaceLicenseToolStripMenuItem";
            this.replaceLicenseToolStripMenuItem.Size = new System.Drawing.Size(327, 42);
            this.replaceLicenseToolStripMenuItem.Text = "Replace License";
            this.replaceLicenseToolStripMenuItem.Click += new System.EventHandler(this.replaceLicenseToolStripMenuItem_Click);
            // 
            // detiningLicenseToolStripMenuItem
            // 
            this.detiningLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_detain_50__1_;
            this.detiningLicenseToolStripMenuItem.Name = "detiningLicenseToolStripMenuItem";
            this.detiningLicenseToolStripMenuItem.Size = new System.Drawing.Size(327, 42);
            this.detiningLicenseToolStripMenuItem.Text = "Detining License";
            this.detiningLicenseToolStripMenuItem.Click += new System.EventHandler(this.detiningLicenseToolStripMenuItem_Click);
            // 
            // maneageApplicationToolStripMenuItem
            // 
            this.maneageApplicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLocalLicenseToolStripMenuItem,
            this.addGlobalLicenseToolStripMenuItem});
            this.maneageApplicationToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_license_100;
            this.maneageApplicationToolStripMenuItem.Name = "maneageApplicationToolStripMenuItem";
            this.maneageApplicationToolStripMenuItem.Size = new System.Drawing.Size(466, 56);
            this.maneageApplicationToolStripMenuItem.Text = "Maneage Application";
            this.maneageApplicationToolStripMenuItem.Click += new System.EventHandler(this.maneageApplicationToolStripMenuItem_Click);
            // 
            // addLocalLicenseToolStripMenuItem
            // 
            this.addLocalLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_taxi_license_100;
            this.addLocalLicenseToolStripMenuItem.Name = "addLocalLicenseToolStripMenuItem";
            this.addLocalLicenseToolStripMenuItem.Size = new System.Drawing.Size(336, 42);
            this.addLocalLicenseToolStripMenuItem.Text = "Add Local License";
            this.addLocalLicenseToolStripMenuItem.Click += new System.EventHandler(this.addLocalLicenseToolStripMenuItem_Click);
            // 
            // addGlobalLicenseToolStripMenuItem
            // 
            this.addGlobalLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_passport_100;
            this.addGlobalLicenseToolStripMenuItem.Name = "addGlobalLicenseToolStripMenuItem";
            this.addGlobalLicenseToolStripMenuItem.Size = new System.Drawing.Size(336, 42);
            this.addGlobalLicenseToolStripMenuItem.Text = "Add Global License";
            this.addGlobalLicenseToolStripMenuItem.Click += new System.EventHandler(this.addGlobalLicenseToolStripMenuItem_Click);
            // 
            // detinToolStripMenuItem
            // 
            this.detinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetiningToolStripMenuItem,
            this.detiningLicenseToolStripMenuItem1,
            this.relaseLicenseToolStripMenuItem});
            this.detinToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_detain_50__1_1;
            this.detinToolStripMenuItem.Name = "detinToolStripMenuItem";
            this.detinToolStripMenuItem.Size = new System.Drawing.Size(466, 56);
            this.detinToolStripMenuItem.Text = "Detining License";
            // 
            // manageDetiningToolStripMenuItem
            // 
            this.manageDetiningToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_customer_insights_manager_64;
            this.manageDetiningToolStripMenuItem.Name = "manageDetiningToolStripMenuItem";
            this.manageDetiningToolStripMenuItem.Size = new System.Drawing.Size(344, 56);
            this.manageDetiningToolStripMenuItem.Text = "Manage Detining";
            this.manageDetiningToolStripMenuItem.Click += new System.EventHandler(this.manageDetiningToolStripMenuItem_Click);
            // 
            // detiningLicenseToolStripMenuItem1
            // 
            this.detiningLicenseToolStripMenuItem1.Image = global::DVLD_Project.Properties.Resources.icons8_detain_50__1_1;
            this.detiningLicenseToolStripMenuItem1.Name = "detiningLicenseToolStripMenuItem1";
            this.detiningLicenseToolStripMenuItem1.Size = new System.Drawing.Size(344, 56);
            this.detiningLicenseToolStripMenuItem1.Text = "Detining License";
            // 
            // relaseLicenseToolStripMenuItem
            // 
            this.relaseLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_identity_theft_501;
            this.relaseLicenseToolStripMenuItem.Name = "relaseLicenseToolStripMenuItem";
            this.relaseLicenseToolStripMenuItem.Size = new System.Drawing.Size(344, 56);
            this.relaseLicenseToolStripMenuItem.Text = "Relase License";
            this.relaseLicenseToolStripMenuItem.Click += new System.EventHandler(this.relaseLicenseToolStripMenuItem_Click);
            // 
            // maneageApplicationTypesToolStripMenuItem
            // 
            this.maneageApplicationTypesToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_cloud_document_641;
            this.maneageApplicationTypesToolStripMenuItem.Name = "maneageApplicationTypesToolStripMenuItem";
            this.maneageApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(466, 56);
            this.maneageApplicationTypesToolStripMenuItem.Text = "Maneage Application Types";
            this.maneageApplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.maneageApplicationTypesToolStripMenuItem_Click);
            // 
            // maneageTestsTypesToolStripMenuItem
            // 
            this.maneageTestsTypesToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_test_641;
            this.maneageTestsTypesToolStripMenuItem.Name = "maneageTestsTypesToolStripMenuItem";
            this.maneageTestsTypesToolStripMenuItem.Size = new System.Drawing.Size(466, 56);
            this.maneageTestsTypesToolStripMenuItem.Text = "Maneage Tests Types";
            this.maneageTestsTypesToolStripMenuItem.Click += new System.EventHandler(this.maneageTestsTypesToolStripMenuItem_Click);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.peopleToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_nation_64;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(162, 54);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.driversToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_taxi_driver_64;
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(163, 54);
            this.driversToolStripMenuItem.Text = "Drivers";
            this.driversToolStripMenuItem.Click += new System.EventHandler(this.driversToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.usersToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_users_64;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(145, 54);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showUserInformationsToolStripMenuItem,
            this.changePassWordToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.settingsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_settings_64;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(176, 54);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // showUserInformationsToolStripMenuItem
            // 
            this.showUserInformationsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_info_64;
            this.showUserInformationsToolStripMenuItem.Name = "showUserInformationsToolStripMenuItem";
            this.showUserInformationsToolStripMenuItem.Size = new System.Drawing.Size(376, 42);
            this.showUserInformationsToolStripMenuItem.Text = "ShowUserInformations";
            this.showUserInformationsToolStripMenuItem.Click += new System.EventHandler(this.showUserInformationsToolStripMenuItem_Click);
            // 
            // changePassWordToolStripMenuItem
            // 
            this.changePassWordToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_password_64__1_;
            this.changePassWordToolStripMenuItem.Name = "changePassWordToolStripMenuItem";
            this.changePassWordToolStripMenuItem.Size = new System.Drawing.Size(376, 42);
            this.changePassWordToolStripMenuItem.Text = "Change PassWord";
            this.changePassWordToolStripMenuItem.Click += new System.EventHandler(this.changePassWordToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_logout_64;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(376, 42);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DVLD_Project.Properties.Resources.MobileCode__2_;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showUserInformationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePassWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maneageApplicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maneageTestsTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maneageApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivingLicenseServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeNewLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newLocaleLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newInternationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLocalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGlobalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detiningLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetiningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detiningLicenseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relaseLicenseToolStripMenuItem;
    }
}

