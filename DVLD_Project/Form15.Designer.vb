Namespace DVLD_Project
    Partial Class Form15
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
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form15))
            tabControl1 = New Windows.Forms.TabControl()
            tabPage1 = New Windows.Forms.TabPage()
            guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
            guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
            guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
            label5 = New Windows.Forms.Label()
            guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
            cbFilters = New Guna.UI2.WinForms.Guna2ComboBox()
            getInformations1 = New GetInformations()
            tabPage2 = New Windows.Forms.TabPage()
            lblCreateBy = New Windows.Forms.Label()
            label6 = New Windows.Forms.Label()
            pictureBox4 = New Windows.Forms.PictureBox()
            lblFees = New Windows.Forms.Label()
            label2 = New Windows.Forms.Label()
            pictureBox3 = New Windows.Forms.PictureBox()
            cbClassesName = New Guna.UI2.WinForms.Guna2ComboBox()
            lblDate = New Windows.Forms.Label()
            label7 = New Windows.Forms.Label()
            pictureBox6 = New Windows.Forms.PictureBox()
            lblAppID = New Windows.Forms.Label()
            lblUserID = New Windows.Forms.Label()
            label4 = New Windows.Forms.Label()
            guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
            guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
            pictureBox1 = New Windows.Forms.PictureBox()
            pictureBox2 = New Windows.Forms.PictureBox()
            tabControl1.SuspendLayout()
            tabPage1.SuspendLayout()
            tabPage2.SuspendLayout()
            CType(pictureBox4, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox3, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox6, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox2, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' tabControl1
            ' 
            tabControl1.Controls.Add(tabPage1)
            tabControl1.Controls.Add(tabPage2)
            tabControl1.Location = New Drawing.Point(9, 56)
            tabControl1.Name = "tabControl1"
            tabControl1.SelectedIndex = 0
            tabControl1.Size = New Drawing.Size(927, 517)
            tabControl1.TabIndex = 1
            AddHandler tabControl1.Selecting, New Windows.Forms.TabControlCancelEventHandler(AddressOf tabControl1_Selecting)
            ' 
            ' tabPage1
            ' 
            tabPage1.Controls.Add(guna2Button5)
            tabPage1.Controls.Add(guna2Button4)
            tabPage1.Controls.Add(guna2Button3)
            tabPage1.Controls.Add(label5)
            tabPage1.Controls.Add(guna2TextBox1)
            tabPage1.Controls.Add(cbFilters)
            tabPage1.Controls.Add(getInformations1)
            tabPage1.Location = New Drawing.Point(4, 25)
            tabPage1.Name = "tabPage1"
            tabPage1.Padding = New Windows.Forms.Padding(3)
            tabPage1.Size = New Drawing.Size(919, 488)
            tabPage1.TabIndex = 0
            tabPage1.Text = "Person"
            tabPage1.UseVisualStyleBackColor = True
            ' 
            ' guna2Button5
            ' 
            guna2Button5.CheckedState.Parent = guna2Button5
            guna2Button5.CustomImages.Parent = guna2Button5
            guna2Button5.FillColor = Drawing.Color.Transparent
            guna2Button5.Font = New Drawing.Font("Segoe UI", 9F)
            guna2Button5.ForeColor = Drawing.Color.Black
            guna2Button5.HoverState.Parent = guna2Button5
            guna2Button5.Image = Global.DVLD_Project.Properties.Resources.icons8_next_64
            guna2Button5.Location = New Drawing.Point(835, 437)
            guna2Button5.Name = "guna2Button5"
            guna2Button5.ShadowDecoration.Parent = guna2Button5
            guna2Button5.Size = New Drawing.Size(78, 45)
            guna2Button5.TabIndex = 27
            guna2Button5.Text = "Next"
            ' 
            ' guna2Button4
            ' 
            guna2Button4.CheckedState.Parent = guna2Button4
            guna2Button4.CustomImages.Parent = guna2Button4
            guna2Button4.FillColor = Drawing.Color.Transparent
            guna2Button4.Font = New Drawing.Font("Segoe UI", 9F)
            guna2Button4.ForeColor = Drawing.SystemColors.Window
            guna2Button4.HoverState.Parent = guna2Button4
            guna2Button4.Image = Global.DVLD_Project.Properties.Resources.icons8_add_male_user_64
            guna2Button4.ImageSize = New Drawing.Size(64, 64)
            guna2Button4.Location = New Drawing.Point(838, 120)
            guna2Button4.Name = "guna2Button4"
            guna2Button4.ShadowDecoration.Parent = guna2Button4
            guna2Button4.Size = New Drawing.Size(75, 65)
            guna2Button4.TabIndex = 26
            ' 
            ' guna2Button3
            ' 
            guna2Button3.CheckedState.Parent = guna2Button3
            guna2Button3.CustomImages.Parent = guna2Button3
            guna2Button3.FillColor = Drawing.Color.Transparent
            guna2Button3.Font = New Drawing.Font("Segoe UI", 9F)
            guna2Button3.ForeColor = Drawing.SystemColors.Window
            guna2Button3.HoverState.Parent = guna2Button3
            guna2Button3.Image = Global.DVLD_Project.Properties.Resources.icons8_search_account_64
            guna2Button3.ImageSize = New Drawing.Size(50, 50)
            guna2Button3.Location = New Drawing.Point(771, 120)
            guna2Button3.Name = "guna2Button3"
            guna2Button3.ShadowDecoration.Parent = guna2Button3
            guna2Button3.Size = New Drawing.Size(65, 65)
            guna2Button3.TabIndex = 25
            ' 
            ' label5
            ' 
            label5.AutoSize = True
            label5.Font = New Drawing.Font("Modern No. 20", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label5.Location = New Drawing.Point(11, 140)
            label5.Name = "label5"
            label5.Size = New Drawing.Size(56, 22)
            label5.TabIndex = 24
            label5.Text = "Filter"
            ' 
            ' guna2TextBox1
            ' 
            guna2TextBox1.AutoRoundedCorners = True
            guna2TextBox1.BorderColor = Drawing.Color.FromArgb(255, 128, 128)
            guna2TextBox1.BorderRadius = 16
            guna2TextBox1.Cursor = Windows.Forms.Cursors.IBeam
            guna2TextBox1.DefaultText = ""
            guna2TextBox1.DisabledState.BorderColor = Drawing.Color.FromArgb(208, 208, 208)
            guna2TextBox1.DisabledState.FillColor = Drawing.Color.FromArgb(226, 226, 226)
            guna2TextBox1.DisabledState.ForeColor = Drawing.Color.FromArgb(138, 138, 138)
            guna2TextBox1.DisabledState.Parent = guna2TextBox1
            guna2TextBox1.DisabledState.PlaceholderForeColor = Drawing.Color.FromArgb(138, 138, 138)
            guna2TextBox1.FocusedState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            guna2TextBox1.FocusedState.Parent = guna2TextBox1
            guna2TextBox1.HoverState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            guna2TextBox1.HoverState.Parent = guna2TextBox1
            guna2TextBox1.Location = New Drawing.Point(357, 134)
            guna2TextBox1.Margin = New Windows.Forms.Padding(4, 4, 4, 4)
            guna2TextBox1.Name = "guna2TextBox1"
            guna2TextBox1.PasswordChar = ChrW(0)
            guna2TextBox1.PlaceholderText = ""
            guna2TextBox1.SelectedText = ""
            guna2TextBox1.ShadowDecoration.Parent = guna2TextBox1
            guna2TextBox1.Size = New Drawing.Size(267, 35)
            guna2TextBox1.TabIndex = 23
            AddHandler guna2TextBox1.TextChanged, New EventHandler(AddressOf guna2TextBox1_TextChanged)
            ' 
            ' cbFilters
            ' 
            cbFilters.BackColor = Drawing.Color.Transparent
            cbFilters.DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
            cbFilters.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
            cbFilters.FocusedColor = Drawing.Color.Empty
            cbFilters.FocusedState.Parent = cbFilters
            cbFilters.Font = New Drawing.Font("Segoe UI", 10F)
            cbFilters.ForeColor = Drawing.Color.FromArgb(68, 88, 112)
            cbFilters.FormattingEnabled = True
            cbFilters.HoverState.Parent = cbFilters
            cbFilters.ItemHeight = 30
            cbFilters.ItemsAppearance.Parent = cbFilters
            cbFilters.Location = New Drawing.Point(87, 133)
            cbFilters.Name = "cbFilters"
            cbFilters.ShadowDecoration.Parent = cbFilters
            cbFilters.Size = New Drawing.Size(263, 36)
            cbFilters.TabIndex = 22
            ' 
            ' getInformations1
            ' 
            getInformations1.Location = New Drawing.Point(97, 111)
            getInformations1.Name = "getInformations1"
            getInformations1.Size = New Drawing.Size(739, 371)
            getInformations1.TabIndex = 0
            ' 
            ' tabPage2
            ' 
            tabPage2.BackColor = Drawing.Color.FromArgb(240, 240, 240)
            tabPage2.Controls.Add(lblCreateBy)
            tabPage2.Controls.Add(label6)
            tabPage2.Controls.Add(pictureBox4)
            tabPage2.Controls.Add(lblFees)
            tabPage2.Controls.Add(label2)
            tabPage2.Controls.Add(pictureBox3)
            tabPage2.Controls.Add(cbClassesName)
            tabPage2.Controls.Add(lblDate)
            tabPage2.Controls.Add(label7)
            tabPage2.Controls.Add(pictureBox6)
            tabPage2.Controls.Add(lblAppID)
            tabPage2.Controls.Add(lblUserID)
            tabPage2.Controls.Add(label4)
            tabPage2.Controls.Add(guna2Button2)
            tabPage2.Controls.Add(guna2Button1)
            tabPage2.Controls.Add(pictureBox1)
            tabPage2.Controls.Add(pictureBox2)
            tabPage2.Location = New Drawing.Point(4, 25)
            tabPage2.Name = "tabPage2"
            tabPage2.Padding = New Windows.Forms.Padding(3)
            tabPage2.Size = New Drawing.Size(919, 488)
            tabPage2.TabIndex = 1
            tabPage2.Text = "License"
            AddHandler tabPage2.Click, New EventHandler(AddressOf tabPage2_Click)
            ' 
            ' lblCreateBy
            ' 
            lblCreateBy.AutoSize = True
            lblCreateBy.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblCreateBy.Location = New Drawing.Point(174, 211)
            lblCreateBy.Name = "lblCreateBy"
            lblCreateBy.Size = New Drawing.Size(30, 16)
            lblCreateBy.TabIndex = 69
            lblCreateBy.Text = "N/A"
            ' 
            ' label6
            ' 
            label6.AutoSize = True
            label6.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label6.Location = New Drawing.Point(18, 211)
            label6.Name = "label6"
            label6.Size = New Drawing.Size(74, 16)
            label6.TabIndex = 67
            label6.Text = "Created By"
            ' 
            ' pictureBox4
            ' 
            pictureBox4.Image = Global.DVLD_Project.Properties.Resources.icons8_person_64
            pictureBox4.Location = New Drawing.Point(108, 196)
            pictureBox4.Name = "pictureBox4"
            pictureBox4.Size = New Drawing.Size(33, 31)
            pictureBox4.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox4.TabIndex = 68
            pictureBox4.TabStop = False
            ' 
            ' lblFees
            ' 
            lblFees.AutoSize = True
            lblFees.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblFees.Location = New Drawing.Point(175, 172)
            lblFees.Name = "lblFees"
            lblFees.Size = New Drawing.Size(30, 16)
            lblFees.TabIndex = 66
            lblFees.Text = "N/A"
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label2.Location = New Drawing.Point(19, 172)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(38, 16)
            label2.TabIndex = 64
            label2.Text = "Fees"
            ' 
            ' pictureBox3
            ' 
            pictureBox3.Image = Global.DVLD_Project.Properties.Resources.icons8_money_64
            pictureBox3.Location = New Drawing.Point(109, 157)
            pictureBox3.Name = "pictureBox3"
            pictureBox3.Size = New Drawing.Size(33, 31)
            pictureBox3.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox3.TabIndex = 65
            pictureBox3.TabStop = False
            ' 
            ' cbClassesName
            ' 
            cbClassesName.BackColor = Drawing.Color.Transparent
            cbClassesName.DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
            cbClassesName.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
            cbClassesName.FocusedColor = Drawing.Color.Empty
            cbClassesName.FocusedState.Parent = cbClassesName
            cbClassesName.Font = New Drawing.Font("Segoe UI", 10F)
            cbClassesName.ForeColor = Drawing.Color.FromArgb(68, 88, 112)
            cbClassesName.FormattingEnabled = True
            cbClassesName.HoverState.Parent = cbClassesName
            cbClassesName.ItemHeight = 30
            cbClassesName.ItemsAppearance.Parent = cbClassesName
            cbClassesName.Location = New Drawing.Point(178, 116)
            cbClassesName.Name = "cbClassesName"
            cbClassesName.ShadowDecoration.Parent = cbClassesName
            cbClassesName.Size = New Drawing.Size(227, 36)
            cbClassesName.TabIndex = 63
            ' 
            ' lblDate
            ' 
            lblDate.AutoSize = True
            lblDate.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblDate.Location = New Drawing.Point(175, 92)
            lblDate.Name = "lblDate"
            lblDate.Size = New Drawing.Size(30, 16)
            lblDate.TabIndex = 62
            lblDate.Text = "N/A"
            ' 
            ' label7
            ' 
            label7.AutoSize = True
            label7.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label7.Location = New Drawing.Point(18, 131)
            label7.Name = "label7"
            label7.Size = New Drawing.Size(73, 16)
            label7.TabIndex = 59
            label7.Text = "LicClasses"
            ' 
            ' pictureBox6
            ' 
            pictureBox6.Image = CType(resources.GetObject("pictureBox6.Image"), Drawing.Image)
            pictureBox6.Location = New Drawing.Point(108, 116)
            pictureBox6.Name = "pictureBox6"
            pictureBox6.Size = New Drawing.Size(33, 31)
            pictureBox6.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox6.TabIndex = 60
            pictureBox6.TabStop = False
            ' 
            ' lblAppID
            ' 
            lblAppID.AutoSize = True
            lblAppID.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblAppID.Location = New Drawing.Point(175, 52)
            lblAppID.Name = "lblAppID"
            lblAppID.Size = New Drawing.Size(30, 16)
            lblAppID.TabIndex = 13
            lblAppID.Text = "N/A"
            ' 
            ' lblUserID
            ' 
            lblUserID.AutoSize = True
            lblUserID.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblUserID.Location = New Drawing.Point(19, 52)
            lblUserID.Name = "lblUserID"
            lblUserID.Size = New Drawing.Size(84, 16)
            lblUserID.TabIndex = 12
            lblUserID.Text = "ApplcationID"
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label4.Location = New Drawing.Point(19, 92)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(64, 16)
            label4.TabIndex = 15
            label4.Text = "App Date"
            ' 
            ' guna2Button2
            ' 
            guna2Button2.BorderColor = Drawing.Color.White
            guna2Button2.CheckedState.Parent = guna2Button2
            guna2Button2.CustomImages.Parent = guna2Button2
            guna2Button2.FillColor = Drawing.Color.White
            guna2Button2.Font = New Drawing.Font("Segoe UI", 9F)
            guna2Button2.ForeColor = Drawing.Color.Black
            guna2Button2.HoverState.Parent = guna2Button2
            guna2Button2.Image = Global.DVLD_Project.Properties.Resources.icons8_cancel_64
            guna2Button2.ImageAlign = Windows.Forms.HorizontalAlignment.Right
            guna2Button2.ImageSize = New Drawing.Size(30, 30)
            guna2Button2.Location = New Drawing.Point(607, 442)
            guna2Button2.Name = "guna2Button2"
            guna2Button2.ShadowDecoration.Parent = guna2Button2
            guna2Button2.Size = New Drawing.Size(119, 42)
            guna2Button2.TabIndex = 40
            guna2Button2.Text = "Cancel"
            guna2Button2.TextAlign = Windows.Forms.HorizontalAlignment.Right
            ' 
            ' guna2Button1
            ' 
            guna2Button1.BorderColor = Drawing.Color.White
            guna2Button1.CheckedState.Parent = guna2Button1
            guna2Button1.CustomImages.Parent = guna2Button1
            guna2Button1.FillColor = Drawing.Color.White
            guna2Button1.Font = New Drawing.Font("Segoe UI", 9F)
            guna2Button1.ForeColor = Drawing.Color.Black
            guna2Button1.HoverState.Parent = guna2Button1
            guna2Button1.Image = Global.DVLD_Project.Properties.Resources.icons8_save_64__1_
            guna2Button1.ImageAlign = Windows.Forms.HorizontalAlignment.Right
            guna2Button1.ImageSize = New Drawing.Size(30, 30)
            guna2Button1.Location = New Drawing.Point(740, 442)
            guna2Button1.Name = "guna2Button1"
            guna2Button1.ShadowDecoration.Parent = guna2Button1
            guna2Button1.Size = New Drawing.Size(119, 42)
            guna2Button1.TabIndex = 39
            guna2Button1.Text = "Sava"
            guna2Button1.TextAlign = Windows.Forms.HorizontalAlignment.Right
            AddHandler guna2Button1.Click, New EventHandler(AddressOf guna2Button1_Click)
            ' 
            ' pictureBox1
            ' 
            pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), Drawing.Image)
            pictureBox1.Location = New Drawing.Point(109, 37)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(33, 31)
            pictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox1.TabIndex = 14
            pictureBox1.TabStop = False
            ' 
            ' pictureBox2
            ' 
            pictureBox2.Image = Global.DVLD_Project.Properties.Resources.icons8_date_64
            pictureBox2.Location = New Drawing.Point(109, 77)
            pictureBox2.Name = "pictureBox2"
            pictureBox2.Size = New Drawing.Size(33, 31)
            pictureBox2.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox2.TabIndex = 16
            pictureBox2.TabStop = False
            ' 
            ' Form15
            ' 
            AutoScaleDimensions = New Drawing.SizeF(8F, 16F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(945, 586)
            Controls.Add(tabControl1)
            Name = "Form15"
            Text = "Form15"
            AddHandler Load, New EventHandler(AddressOf Form15_Load)
            tabControl1.ResumeLayout(False)
            tabPage1.ResumeLayout(False)
            tabPage1.PerformLayout()
            tabPage2.ResumeLayout(False)
            tabPage2.PerformLayout()
            CType(pictureBox4, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox3, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox6, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox2, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)

        End Sub

#End Region

        Private tabControl1 As Windows.Forms.TabControl
        Private tabPage1 As Windows.Forms.TabPage
        Private guna2Button5 As Guna.UI2.WinForms.Guna2Button
        Private guna2Button4 As Guna.UI2.WinForms.Guna2Button
        Private guna2Button3 As Guna.UI2.WinForms.Guna2Button
        Private label5 As Windows.Forms.Label
        Private guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
        Private cbFilters As Guna.UI2.WinForms.Guna2ComboBox
        Private getInformations1 As GetInformations
        Private tabPage2 As Windows.Forms.TabPage
        Private label7 As Windows.Forms.Label
        Private pictureBox6 As Windows.Forms.PictureBox
        Private lblAppID As Windows.Forms.Label
        Private lblUserID As Windows.Forms.Label
        Private label4 As Windows.Forms.Label
        Private guna2Button2 As Guna.UI2.WinForms.Guna2Button
        Private guna2Button1 As Guna.UI2.WinForms.Guna2Button
        Private pictureBox1 As Windows.Forms.PictureBox
        Private pictureBox2 As Windows.Forms.PictureBox
        Private lblDate As Windows.Forms.Label
        Private lblCreateBy As Windows.Forms.Label
        Private label6 As Windows.Forms.Label
        Private pictureBox4 As Windows.Forms.PictureBox
        Private lblFees As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
        Private pictureBox3 As Windows.Forms.PictureBox
        Private cbClassesName As Guna.UI2.WinForms.Guna2ComboBox
    End Class
End Namespace
