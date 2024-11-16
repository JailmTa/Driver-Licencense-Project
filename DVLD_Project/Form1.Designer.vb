Namespace DVLD_Project
    Partial Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            menuStrip1 = New Windows.Forms.MenuStrip()
            aplaToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            maneageApplicationTypesToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            maneageTestsTypesToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            maneageApplicationToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            drivingLicenseServerToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            makeNewLicenseToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            newLocaleLicenseToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            newInternationalLicenseToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            peopleToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            driversToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            usersToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            settingsToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            showUserInformationsToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            changePassWordToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            logoutToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            menuStrip1.SuspendLayout()
            SuspendLayout()
            ' 
            ' menuStrip1
            ' 
            menuStrip1.ImageScalingSize = New Drawing.Size(50, 50)
            menuStrip1.Items.AddRange(New Windows.Forms.ToolStripItem() {aplaToolStripMenuItem, peopleToolStripMenuItem, driversToolStripMenuItem, usersToolStripMenuItem, settingsToolStripMenuItem})
            menuStrip1.Location = New Drawing.Point(0, 0)
            menuStrip1.Name = "menuStrip1"
            menuStrip1.Size = New Drawing.Size(1902, 58)
            menuStrip1.TabIndex = 0
            menuStrip1.Text = "menuStrip1"
            ' 
            ' aplaToolStripMenuItem
            ' 
            aplaToolStripMenuItem.DropDownItems.AddRange(New Windows.Forms.ToolStripItem() {maneageApplicationTypesToolStripMenuItem, maneageTestsTypesToolStripMenuItem, maneageApplicationToolStripMenuItem, drivingLicenseServerToolStripMenuItem})
            aplaToolStripMenuItem.Font = New Drawing.Font("Segoe UI", 16F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            aplaToolStripMenuItem.Image = Global.DVLD_Project.Properties.Resources.icons8_archive_64
            aplaToolStripMenuItem.ImageAlign = Drawing.ContentAlignment.MiddleLeft
            aplaToolStripMenuItem.Name = "aplaToolStripMenuItem"
            aplaToolStripMenuItem.Size = New Drawing.Size(235, 54)
            aplaToolStripMenuItem.Text = "Applacations"
            ' 
            ' maneageApplicationTypesToolStripMenuItem
            ' 
            maneageApplicationTypesToolStripMenuItem.Image = Global.DVLD_Project.Properties.Resources.icons8_cloud_document_641
            maneageApplicationTypesToolStripMenuItem.Name = "maneageApplicationTypesToolStripMenuItem"
            maneageApplicationTypesToolStripMenuItem.Size = New Drawing.Size(436, 42)
            maneageApplicationTypesToolStripMenuItem.Text = "Maneage Application Types"
            AddHandler maneageApplicationTypesToolStripMenuItem.Click, New EventHandler(AddressOf maneageApplicationTypesToolStripMenuItem_Click)
            ' 
            ' maneageTestsTypesToolStripMenuItem
            ' 
            maneageTestsTypesToolStripMenuItem.Image = Global.DVLD_Project.Properties.Resources.icons8_test_641
            maneageTestsTypesToolStripMenuItem.Name = "maneageTestsTypesToolStripMenuItem"
            maneageTestsTypesToolStripMenuItem.Size = New Drawing.Size(436, 42)
            maneageTestsTypesToolStripMenuItem.Text = "Maneage Tests Types"
            AddHandler maneageTestsTypesToolStripMenuItem.Click, New EventHandler(AddressOf maneageTestsTypesToolStripMenuItem_Click)
            ' 
            ' maneageApplicationToolStripMenuItem
            ' 
            maneageApplicationToolStripMenuItem.Image = Global.DVLD_Project.Properties.Resources.icons8_license_100
            maneageApplicationToolStripMenuItem.Name = "maneageApplicationToolStripMenuItem"
            maneageApplicationToolStripMenuItem.Size = New Drawing.Size(436, 42)
            maneageApplicationToolStripMenuItem.Text = "Maneage Application"
            AddHandler maneageApplicationToolStripMenuItem.Click, New EventHandler(AddressOf maneageApplicationToolStripMenuItem_Click)
            ' 
            ' drivingLicenseServerToolStripMenuItem
            ' 
            drivingLicenseServerToolStripMenuItem.DropDownItems.AddRange(New Windows.Forms.ToolStripItem() {makeNewLicenseToolStripMenuItem})
            drivingLicenseServerToolStripMenuItem.Name = "drivingLicenseServerToolStripMenuItem"
            drivingLicenseServerToolStripMenuItem.Size = New Drawing.Size(436, 42)
            drivingLicenseServerToolStripMenuItem.Text = "Driving License Server"
            AddHandler drivingLicenseServerToolStripMenuItem.Click, New EventHandler(AddressOf drivingLicenseServerToolStripMenuItem_Click)
            ' 
            ' makeNewLicenseToolStripMenuItem
            ' 
            makeNewLicenseToolStripMenuItem.DropDownItems.AddRange(New Windows.Forms.ToolStripItem() {newLocaleLicenseToolStripMenuItem, newInternationalLicenseToolStripMenuItem})
            makeNewLicenseToolStripMenuItem.Name = "makeNewLicenseToolStripMenuItem"
            makeNewLicenseToolStripMenuItem.Size = New Drawing.Size(327, 42)
            makeNewLicenseToolStripMenuItem.Text = "Make New License"
            ' 
            ' newLocaleLicenseToolStripMenuItem
            ' 
            newLocaleLicenseToolStripMenuItem.Image = Global.DVLD_Project.Properties.Resources.icons8_taxi_license_100
            newLocaleLicenseToolStripMenuItem.Name = "newLocaleLicenseToolStripMenuItem"
            newLocaleLicenseToolStripMenuItem.Size = New Drawing.Size(413, 42)
            newLocaleLicenseToolStripMenuItem.Text = "New Locale License"
            AddHandler newLocaleLicenseToolStripMenuItem.Click, New EventHandler(AddressOf newLocaleLicenseToolStripMenuItem_Click)
            ' 
            ' newInternationalLicenseToolStripMenuItem
            ' 
            newInternationalLicenseToolStripMenuItem.Image = Global.DVLD_Project.Properties.Resources.icons8_passport_100
            newInternationalLicenseToolStripMenuItem.Name = "newInternationalLicenseToolStripMenuItem"
            newInternationalLicenseToolStripMenuItem.Size = New Drawing.Size(413, 42)
            newInternationalLicenseToolStripMenuItem.Text = "New International License"
            ' 
            ' peopleToolStripMenuItem
            ' 
            peopleToolStripMenuItem.Font = New Drawing.Font("Segoe UI", 16F)
            peopleToolStripMenuItem.Image = Global.DVLD_Project.Properties.Resources.icons8_nation_64
            peopleToolStripMenuItem.Name = "peopleToolStripMenuItem"
            peopleToolStripMenuItem.Size = New Drawing.Size(162, 54)
            peopleToolStripMenuItem.Text = "People"
            AddHandler peopleToolStripMenuItem.Click, New EventHandler(AddressOf peopleToolStripMenuItem_Click)
            ' 
            ' driversToolStripMenuItem
            ' 
            driversToolStripMenuItem.Font = New Drawing.Font("Segoe UI", 16F)
            driversToolStripMenuItem.Image = Global.DVLD_Project.Properties.Resources.icons8_taxi_driver_64
            driversToolStripMenuItem.Name = "driversToolStripMenuItem"
            driversToolStripMenuItem.Size = New Drawing.Size(163, 54)
            driversToolStripMenuItem.Text = "Drivers"
            AddHandler driversToolStripMenuItem.Click, New EventHandler(AddressOf driversToolStripMenuItem_Click)
            ' 
            ' usersToolStripMenuItem
            ' 
            usersToolStripMenuItem.Font = New Drawing.Font("Segoe UI", 16F)
            usersToolStripMenuItem.Image = Global.DVLD_Project.Properties.Resources.icons8_users_64
            usersToolStripMenuItem.Name = "usersToolStripMenuItem"
            usersToolStripMenuItem.Size = New Drawing.Size(145, 54)
            usersToolStripMenuItem.Text = "Users"
            AddHandler usersToolStripMenuItem.Click, New EventHandler(AddressOf usersToolStripMenuItem_Click)
            ' 
            ' settingsToolStripMenuItem
            ' 
            settingsToolStripMenuItem.DropDownItems.AddRange(New Windows.Forms.ToolStripItem() {showUserInformationsToolStripMenuItem, changePassWordToolStripMenuItem, logoutToolStripMenuItem})
            settingsToolStripMenuItem.Font = New Drawing.Font("Segoe UI", 16F)
            settingsToolStripMenuItem.Image = Global.DVLD_Project.Properties.Resources.icons8_settings_64
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem"
            settingsToolStripMenuItem.Size = New Drawing.Size(176, 54)
            settingsToolStripMenuItem.Text = "Settings"
            AddHandler settingsToolStripMenuItem.Click, New EventHandler(AddressOf settingsToolStripMenuItem_Click)
            ' 
            ' showUserInformationsToolStripMenuItem
            ' 
            showUserInformationsToolStripMenuItem.Image = Global.DVLD_Project.Properties.Resources.icons8_info_64
            showUserInformationsToolStripMenuItem.Name = "showUserInformationsToolStripMenuItem"
            showUserInformationsToolStripMenuItem.Size = New Drawing.Size(376, 42)
            showUserInformationsToolStripMenuItem.Text = "ShowUserInformations"
            AddHandler showUserInformationsToolStripMenuItem.Click, New EventHandler(AddressOf showUserInformationsToolStripMenuItem_Click)
            ' 
            ' changePassWordToolStripMenuItem
            ' 
            changePassWordToolStripMenuItem.Image = Global.DVLD_Project.Properties.Resources.icons8_password_64__1_
            changePassWordToolStripMenuItem.Name = "changePassWordToolStripMenuItem"
            changePassWordToolStripMenuItem.Size = New Drawing.Size(376, 42)
            changePassWordToolStripMenuItem.Text = "Change PassWord"
            AddHandler changePassWordToolStripMenuItem.Click, New EventHandler(AddressOf changePassWordToolStripMenuItem_Click)
            ' 
            ' logoutToolStripMenuItem
            ' 
            logoutToolStripMenuItem.Image = Global.DVLD_Project.Properties.Resources.icons8_logout_64
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem"
            logoutToolStripMenuItem.Size = New Drawing.Size(376, 42)
            logoutToolStripMenuItem.Text = "Logout"
            AddHandler logoutToolStripMenuItem.Click, New EventHandler(AddressOf logoutToolStripMenuItem_Click)
            ' 
            ' Form1
            ' 
            AutoScaleDimensions = New Drawing.SizeF(8F, 16F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            BackgroundImage = Global.DVLD_Project.Properties.Resources.MobileCode__2_
            ClientSize = New Drawing.Size(1902, 1033)
            Controls.Add(menuStrip1)
            MainMenuStrip = menuStrip1
            Name = "Form1"
            Text = "Form1"
            WindowState = Windows.Forms.FormWindowState.Maximized
            menuStrip1.ResumeLayout(False)
            menuStrip1.PerformLayout()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private menuStrip1 As Windows.Forms.MenuStrip
        Private aplaToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private peopleToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private driversToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private usersToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private settingsToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private showUserInformationsToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private changePassWordToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private logoutToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private maneageApplicationTypesToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private maneageTestsTypesToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private maneageApplicationToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private drivingLicenseServerToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private makeNewLicenseToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private newLocaleLicenseToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private newInternationalLicenseToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    End Class
End Namespace
