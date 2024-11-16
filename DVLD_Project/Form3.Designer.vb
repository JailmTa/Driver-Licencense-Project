Namespace DVLD_Project
    Partial Class Form3
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
            components = New ComponentModel.Container()
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form3))
            label1 = New Windows.Forms.Label()
            label2 = New Windows.Forms.Label()
            groupBox1 = New Windows.Forms.GroupBox()
            linkLabel2 = New Windows.Forms.LinkLabel()
            guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
            guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
            linkLabel1 = New Windows.Forms.LinkLabel()
            pbProfile = New Windows.Forms.PictureBox()
            tbAddreass = New Guna.UI2.WinForms.Guna2TextBox()
            pictureBox10 = New Windows.Forms.PictureBox()
            label11 = New Windows.Forms.Label()
            cbCountry = New Guna.UI2.WinForms.Guna2ComboBox()
            pictureBox9 = New Windows.Forms.PictureBox()
            label10 = New Windows.Forms.Label()
            dtpBirthDate = New Windows.Forms.DateTimePicker()
            pictureBox8 = New Windows.Forms.PictureBox()
            label9 = New Windows.Forms.Label()
            tbPhone = New Guna.UI2.WinForms.Guna2TextBox()
            pictureBox7 = New Windows.Forms.PictureBox()
            label8 = New Windows.Forms.Label()
            tbEmail = New Guna.UI2.WinForms.Guna2TextBox()
            pictureBox6 = New Windows.Forms.PictureBox()
            label7 = New Windows.Forms.Label()
            pictureBox5 = New Windows.Forms.PictureBox()
            rbFemal = New Windows.Forms.RadioButton()
            rbMale = New Windows.Forms.RadioButton()
            pictureBox4 = New Windows.Forms.PictureBox()
            label6 = New Windows.Forms.Label()
            tbNationalID = New Guna.UI2.WinForms.Guna2TextBox()
            tbLastName = New Guna.UI2.WinForms.Guna2TextBox()
            pictureBox3 = New Windows.Forms.PictureBox()
            tbThirdName = New Guna.UI2.WinForms.Guna2TextBox()
            label5 = New Windows.Forms.Label()
            tbSecondName = New Guna.UI2.WinForms.Guna2TextBox()
            tbFirstName = New Guna.UI2.WinForms.Guna2TextBox()
            pictureBox2 = New Windows.Forms.PictureBox()
            label4 = New Windows.Forms.Label()
            lblPersonID = New Windows.Forms.Label()
            errorProvider1 = New Windows.Forms.ErrorProvider(components)
            pictureBox1 = New Windows.Forms.PictureBox()
            openFileDialog1 = New Windows.Forms.OpenFileDialog()
            groupBox1.SuspendLayout()
            CType(pbProfile, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox10, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox9, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox8, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox7, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox6, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox5, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox4, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox3, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox2, ComponentModel.ISupportInitialize).BeginInit()
            CType(errorProvider1, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Font = New Drawing.Font("Microsoft Sans Serif", 18F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label1.ForeColor = Drawing.Color.FromArgb(255, 128, 128)
            label1.Location = New Drawing.Point(306, 9)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(239, 36)
            label1.TabIndex = 3
            label1.Text = "Maneage People"
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label2.Location = New Drawing.Point(26, 67)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(63, 16)
            label2.TabIndex = 4
            label2.Text = "PersonID"
            ' 
            ' groupBox1
            ' 
            groupBox1.Controls.Add(linkLabel2)
            groupBox1.Controls.Add(guna2Button2)
            groupBox1.Controls.Add(guna2Button1)
            groupBox1.Controls.Add(linkLabel1)
            groupBox1.Controls.Add(pbProfile)
            groupBox1.Controls.Add(tbAddreass)
            groupBox1.Controls.Add(pictureBox10)
            groupBox1.Controls.Add(label11)
            groupBox1.Controls.Add(cbCountry)
            groupBox1.Controls.Add(pictureBox9)
            groupBox1.Controls.Add(label10)
            groupBox1.Controls.Add(dtpBirthDate)
            groupBox1.Controls.Add(pictureBox8)
            groupBox1.Controls.Add(label9)
            groupBox1.Controls.Add(tbPhone)
            groupBox1.Controls.Add(pictureBox7)
            groupBox1.Controls.Add(label8)
            groupBox1.Controls.Add(tbEmail)
            groupBox1.Controls.Add(pictureBox6)
            groupBox1.Controls.Add(label7)
            groupBox1.Controls.Add(pictureBox5)
            groupBox1.Controls.Add(rbFemal)
            groupBox1.Controls.Add(rbMale)
            groupBox1.Controls.Add(pictureBox4)
            groupBox1.Controls.Add(label6)
            groupBox1.Controls.Add(tbNationalID)
            groupBox1.Controls.Add(tbLastName)
            groupBox1.Controls.Add(pictureBox3)
            groupBox1.Controls.Add(tbThirdName)
            groupBox1.Controls.Add(label5)
            groupBox1.Controls.Add(tbSecondName)
            groupBox1.Controls.Add(tbFirstName)
            groupBox1.Controls.Add(pictureBox2)
            groupBox1.Controls.Add(label4)
            groupBox1.Location = New Drawing.Point(13, 113)
            groupBox1.Name = "groupBox1"
            groupBox1.Size = New Drawing.Size(858, 340)
            groupBox1.TabIndex = 6
            groupBox1.TabStop = False
            ' 
            ' linkLabel2
            ' 
            linkLabel2.AutoSize = True
            linkLabel2.Location = New Drawing.Point(738, 257)
            linkLabel2.Name = "linkLabel2"
            linkLabel2.Size = New Drawing.Size(65, 16)
            linkLabel2.TabIndex = 39
            linkLabel2.TabStop = True
            linkLabel2.Text = "SetImage"
            AddHandler linkLabel2.LinkClicked, New Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf linkLabel2_LinkClicked)
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
            guna2Button2.Location = New Drawing.Point(413, 292)
            guna2Button2.Name = "guna2Button2"
            guna2Button2.ShadowDecoration.Parent = guna2Button2
            guna2Button2.Size = New Drawing.Size(119, 42)
            guna2Button2.TabIndex = 38
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
            guna2Button1.Location = New Drawing.Point(546, 292)
            guna2Button1.Name = "guna2Button1"
            guna2Button1.ShadowDecoration.Parent = guna2Button1
            guna2Button1.Size = New Drawing.Size(119, 42)
            guna2Button1.TabIndex = 37
            guna2Button1.Text = "Sava"
            guna2Button1.TextAlign = Windows.Forms.HorizontalAlignment.Right
            AddHandler guna2Button1.Click, New EventHandler(AddressOf guna2Button1_Click)
            ' 
            ' linkLabel1
            ' 
            linkLabel1.AutoSize = True
            linkLabel1.Location = New Drawing.Point(722, 241)
            linkLabel1.Name = "linkLabel1"
            linkLabel1.Size = New Drawing.Size(97, 16)
            linkLabel1.TabIndex = 36
            linkLabel1.TabStop = True
            linkLabel1.Text = "RemoveImage"
            AddHandler linkLabel1.LinkClicked, New Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf linkLabel1_LinkClicked)
            ' 
            ' pbProfile
            ' 
            pbProfile.Location = New Drawing.Point(694, 63)
            pbProfile.Name = "pbProfile"
            pbProfile.Size = New Drawing.Size(153, 173)
            pbProfile.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pbProfile.TabIndex = 35
            pbProfile.TabStop = False
            ' 
            ' tbAddreass
            ' 
            tbAddreass.Cursor = Windows.Forms.Cursors.IBeam
            tbAddreass.DefaultText = ""
            tbAddreass.DisabledState.BorderColor = Drawing.Color.FromArgb(208, 208, 208)
            tbAddreass.DisabledState.FillColor = Drawing.Color.FromArgb(226, 226, 226)
            tbAddreass.DisabledState.ForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbAddreass.DisabledState.Parent = tbAddreass
            tbAddreass.DisabledState.PlaceholderForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbAddreass.FocusedState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbAddreass.FocusedState.Parent = tbAddreass
            tbAddreass.HoverState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbAddreass.HoverState.Parent = tbAddreass
            tbAddreass.Location = New Drawing.Point(145, 205)
            tbAddreass.Margin = New Windows.Forms.Padding(4, 4, 4, 4)
            tbAddreass.Multiline = True
            tbAddreass.Name = "tbAddreass"
            tbAddreass.PasswordChar = ChrW(0)
            tbAddreass.PlaceholderText = ""
            tbAddreass.SelectedText = ""
            tbAddreass.ShadowDecoration.Parent = tbAddreass
            tbAddreass.Size = New Drawing.Size(520, 80)
            tbAddreass.TabIndex = 34
            ' 
            ' pictureBox10
            ' 
            pictureBox10.Image = Global.DVLD_Project.Properties.Resources.icons8_shipping_location_64
            pictureBox10.Location = New Drawing.Point(76, 205)
            pictureBox10.Name = "pictureBox10"
            pictureBox10.Size = New Drawing.Size(33, 31)
            pictureBox10.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox10.TabIndex = 33
            pictureBox10.TabStop = False
            ' 
            ' label11
            ' 
            label11.AutoSize = True
            label11.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label11.Location = New Drawing.Point(13, 212)
            label11.Name = "label11"
            label11.Size = New Drawing.Size(66, 16)
            label11.TabIndex = 32
            label11.Text = "Addreass"
            ' 
            ' cbCountry
            ' 
            cbCountry.BackColor = Drawing.Color.Transparent
            cbCountry.DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
            cbCountry.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
            cbCountry.FocusedColor = Drawing.Color.Empty
            cbCountry.FocusedState.Parent = cbCountry
            cbCountry.Font = New Drawing.Font("Segoe UI", 10F)
            cbCountry.ForeColor = Drawing.Color.FromArgb(68, 88, 112)
            cbCountry.FormattingEnabled = True
            cbCountry.HoverState.Parent = cbCountry
            cbCountry.ItemHeight = 30
            cbCountry.ItemsAppearance.Parent = cbCountry
            cbCountry.Location = New Drawing.Point(511, 154)
            cbCountry.Name = "cbCountry"
            cbCountry.ShadowDecoration.Parent = cbCountry
            cbCountry.Size = New Drawing.Size(154, 36)
            cbCountry.TabIndex = 31
            ' 
            ' pictureBox9
            ' 
            pictureBox9.Image = Global.DVLD_Project.Properties.Resources.icons8_worldwide_location_64
            pictureBox9.Location = New Drawing.Point(442, 159)
            pictureBox9.Name = "pictureBox9"
            pictureBox9.Size = New Drawing.Size(33, 31)
            pictureBox9.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox9.TabIndex = 30
            pictureBox9.TabStop = False
            ' 
            ' label10
            ' 
            label10.AutoSize = True
            label10.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label10.Location = New Drawing.Point(379, 166)
            label10.Name = "label10"
            label10.Size = New Drawing.Size(52, 16)
            label10.TabIndex = 29
            label10.Text = "Country"
            ' 
            ' dtpBirthDate
            ' 
            dtpBirthDate.Location = New Drawing.Point(511, 70)
            dtpBirthDate.Name = "dtpBirthDate"
            dtpBirthDate.Size = New Drawing.Size(154, 22)
            dtpBirthDate.TabIndex = 28
            ' 
            ' pictureBox8
            ' 
            pictureBox8.Image = Global.DVLD_Project.Properties.Resources.icons8_date_64
            pictureBox8.Location = New Drawing.Point(442, 63)
            pictureBox8.Name = "pictureBox8"
            pictureBox8.Size = New Drawing.Size(33, 31)
            pictureBox8.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox8.TabIndex = 27
            pictureBox8.TabStop = False
            ' 
            ' label9
            ' 
            label9.AutoSize = True
            label9.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label9.Location = New Drawing.Point(379, 70)
            label9.Name = "label9"
            label9.Size = New Drawing.Size(62, 16)
            label9.TabIndex = 26
            label9.Text = "BirthDate"
            ' 
            ' tbPhone
            ' 
            tbPhone.Cursor = Windows.Forms.Cursors.IBeam
            tbPhone.DefaultText = ""
            tbPhone.DisabledState.BorderColor = Drawing.Color.FromArgb(208, 208, 208)
            tbPhone.DisabledState.FillColor = Drawing.Color.FromArgb(226, 226, 226)
            tbPhone.DisabledState.ForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbPhone.DisabledState.Parent = tbPhone
            tbPhone.DisabledState.PlaceholderForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbPhone.FocusedState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbPhone.FocusedState.Parent = tbPhone
            tbPhone.HoverState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbPhone.HoverState.Parent = tbPhone
            tbPhone.Location = New Drawing.Point(511, 110)
            tbPhone.Margin = New Windows.Forms.Padding(4, 4, 4, 4)
            tbPhone.Name = "tbPhone"
            tbPhone.PasswordChar = ChrW(0)
            tbPhone.PlaceholderText = ""
            tbPhone.SelectedText = ""
            tbPhone.ShadowDecoration.Parent = tbPhone
            tbPhone.Size = New Drawing.Size(154, 31)
            tbPhone.TabIndex = 25
            ' 
            ' pictureBox7
            ' 
            pictureBox7.Image = Global.DVLD_Project.Properties.Resources.icons8_phone_64
            pictureBox7.Location = New Drawing.Point(442, 110)
            pictureBox7.Name = "pictureBox7"
            pictureBox7.Size = New Drawing.Size(33, 31)
            pictureBox7.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox7.TabIndex = 24
            pictureBox7.TabStop = False
            ' 
            ' label8
            ' 
            label8.AutoSize = True
            label8.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label8.Location = New Drawing.Point(379, 117)
            label8.Name = "label8"
            label8.Size = New Drawing.Size(46, 16)
            label8.TabIndex = 23
            label8.Text = "Phone"
            ' 
            ' tbEmail
            ' 
            tbEmail.Cursor = Windows.Forms.Cursors.IBeam
            tbEmail.DefaultText = ""
            tbEmail.DisabledState.BorderColor = Drawing.Color.FromArgb(208, 208, 208)
            tbEmail.DisabledState.FillColor = Drawing.Color.FromArgb(226, 226, 226)
            tbEmail.DisabledState.ForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbEmail.DisabledState.Parent = tbEmail
            tbEmail.DisabledState.PlaceholderForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbEmail.FocusedState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbEmail.FocusedState.Parent = tbEmail
            tbEmail.HoverState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbEmail.HoverState.Parent = tbEmail
            tbEmail.Location = New Drawing.Point(145, 159)
            tbEmail.Margin = New Windows.Forms.Padding(4, 4, 4, 4)
            tbEmail.Name = "tbEmail"
            tbEmail.PasswordChar = ChrW(0)
            tbEmail.PlaceholderText = ""
            tbEmail.SelectedText = ""
            tbEmail.ShadowDecoration.Parent = tbEmail
            tbEmail.Size = New Drawing.Size(154, 31)
            tbEmail.TabIndex = 22
            AddHandler tbEmail.TextChanged, New EventHandler(AddressOf tbEmail_TextChanged)
            AddHandler tbEmail.Validating, New ComponentModel.CancelEventHandler(AddressOf tbEmail_Validating)
            ' 
            ' pictureBox6
            ' 
            pictureBox6.Image = Global.DVLD_Project.Properties.Resources.icons8_email_64
            pictureBox6.Location = New Drawing.Point(76, 159)
            pictureBox6.Name = "pictureBox6"
            pictureBox6.Size = New Drawing.Size(33, 31)
            pictureBox6.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox6.TabIndex = 21
            pictureBox6.TabStop = False
            ' 
            ' label7
            ' 
            label7.AutoSize = True
            label7.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label7.Location = New Drawing.Point(13, 166)
            label7.Name = "label7"
            label7.Size = New Drawing.Size(41, 16)
            label7.TabIndex = 20
            label7.Text = "Email"
            ' 
            ' pictureBox5
            ' 
            pictureBox5.Image = Global.DVLD_Project.Properties.Resources.icons8_female_64
            pictureBox5.Location = New Drawing.Point(190, 110)
            pictureBox5.Name = "pictureBox5"
            pictureBox5.Size = New Drawing.Size(33, 31)
            pictureBox5.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox5.TabIndex = 19
            pictureBox5.TabStop = False
            ' 
            ' rbFemal
            ' 
            rbFemal.AutoSize = True
            rbFemal.Location = New Drawing.Point(232, 121)
            rbFemal.Name = "rbFemal"
            rbFemal.Size = New Drawing.Size(66, 20)
            rbFemal.TabIndex = 18
            rbFemal.TabStop = True
            rbFemal.Text = "Femal"
            rbFemal.UseVisualStyleBackColor = True
            AddHandler rbFemal.CheckedChanged, New EventHandler(AddressOf rbFemal_CheckedChanged)
            ' 
            ' rbMale
            ' 
            rbMale.AutoSize = True
            rbMale.Location = New Drawing.Point(129, 121)
            rbMale.Name = "rbMale"
            rbMale.Size = New Drawing.Size(58, 20)
            rbMale.TabIndex = 17
            rbMale.TabStop = True
            rbMale.Text = "Male"
            rbMale.UseVisualStyleBackColor = True
            AddHandler rbMale.Click, New EventHandler(AddressOf rbMale_Click)
            ' 
            ' pictureBox4
            ' 
            pictureBox4.Image = Global.DVLD_Project.Properties.Resources.icons8_male_64
            pictureBox4.Location = New Drawing.Point(76, 110)
            pictureBox4.Name = "pictureBox4"
            pictureBox4.Size = New Drawing.Size(33, 31)
            pictureBox4.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox4.TabIndex = 16
            pictureBox4.TabStop = False
            ' 
            ' label6
            ' 
            label6.AutoSize = True
            label6.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label6.Location = New Drawing.Point(13, 117)
            label6.Name = "label6"
            label6.Size = New Drawing.Size(52, 16)
            label6.TabIndex = 15
            label6.Text = "Gonder"
            ' 
            ' tbNationalID
            ' 
            tbNationalID.Cursor = Windows.Forms.Cursors.IBeam
            tbNationalID.DefaultText = ""
            tbNationalID.DisabledState.BorderColor = Drawing.Color.FromArgb(208, 208, 208)
            tbNationalID.DisabledState.FillColor = Drawing.Color.FromArgb(226, 226, 226)
            tbNationalID.DisabledState.ForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbNationalID.DisabledState.Parent = tbNationalID
            tbNationalID.DisabledState.PlaceholderForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbNationalID.FocusedState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbNationalID.FocusedState.Parent = tbNationalID
            tbNationalID.HoverState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbNationalID.HoverState.Parent = tbNationalID
            tbNationalID.Location = New Drawing.Point(145, 63)
            tbNationalID.Margin = New Windows.Forms.Padding(4, 4, 4, 4)
            tbNationalID.Name = "tbNationalID"
            tbNationalID.PasswordChar = ChrW(0)
            tbNationalID.PlaceholderText = ""
            tbNationalID.SelectedText = ""
            tbNationalID.ShadowDecoration.Parent = tbNationalID
            tbNationalID.Size = New Drawing.Size(154, 31)
            tbNationalID.TabIndex = 14
            AddHandler tbNationalID.TextChanged, New EventHandler(AddressOf tbNationalID_TextChanged)
            AddHandler tbNationalID.Validating, New ComponentModel.CancelEventHandler(AddressOf tbNationalID_Validating)
            ' 
            ' tbLastName
            ' 
            tbLastName.Cursor = Windows.Forms.Cursors.IBeam
            tbLastName.DefaultText = ""
            tbLastName.DisabledState.BorderColor = Drawing.Color.FromArgb(208, 208, 208)
            tbLastName.DisabledState.FillColor = Drawing.Color.FromArgb(226, 226, 226)
            tbLastName.DisabledState.ForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbLastName.DisabledState.Parent = tbLastName
            tbLastName.DisabledState.PlaceholderForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbLastName.FocusedState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbLastName.FocusedState.Parent = tbLastName
            tbLastName.HoverState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbLastName.HoverState.Parent = tbLastName
            tbLastName.Location = New Drawing.Point(694, 18)
            tbLastName.Margin = New Windows.Forms.Padding(4, 4, 4, 4)
            tbLastName.Name = "tbLastName"
            tbLastName.PasswordChar = ChrW(0)
            tbLastName.PlaceholderText = ""
            tbLastName.SelectedText = ""
            tbLastName.ShadowDecoration.Parent = tbLastName
            tbLastName.Size = New Drawing.Size(154, 31)
            tbLastName.TabIndex = 14
            ' 
            ' pictureBox3
            ' 
            pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), Drawing.Image)
            pictureBox3.Location = New Drawing.Point(76, 63)
            pictureBox3.Name = "pictureBox3"
            pictureBox3.Size = New Drawing.Size(33, 31)
            pictureBox3.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox3.TabIndex = 13
            pictureBox3.TabStop = False
            ' 
            ' tbThirdName
            ' 
            tbThirdName.Cursor = Windows.Forms.Cursors.IBeam
            tbThirdName.DefaultText = ""
            tbThirdName.DisabledState.BorderColor = Drawing.Color.FromArgb(208, 208, 208)
            tbThirdName.DisabledState.FillColor = Drawing.Color.FromArgb(226, 226, 226)
            tbThirdName.DisabledState.ForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbThirdName.DisabledState.Parent = tbThirdName
            tbThirdName.DisabledState.PlaceholderForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbThirdName.FocusedState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbThirdName.FocusedState.Parent = tbThirdName
            tbThirdName.HoverState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbThirdName.HoverState.Parent = tbThirdName
            tbThirdName.Location = New Drawing.Point(511, 18)
            tbThirdName.Margin = New Windows.Forms.Padding(4, 4, 4, 4)
            tbThirdName.Name = "tbThirdName"
            tbThirdName.PasswordChar = ChrW(0)
            tbThirdName.PlaceholderText = ""
            tbThirdName.SelectedText = ""
            tbThirdName.ShadowDecoration.Parent = tbThirdName
            tbThirdName.Size = New Drawing.Size(154, 31)
            tbThirdName.TabIndex = 13
            ' 
            ' label5
            ' 
            label5.AutoSize = True
            label5.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label5.Location = New Drawing.Point(13, 70)
            label5.Name = "label5"
            label5.Size = New Drawing.Size(70, 16)
            label5.TabIndex = 12
            label5.Text = "NationalID"
            ' 
            ' tbSecondName
            ' 
            tbSecondName.Cursor = Windows.Forms.Cursors.IBeam
            tbSecondName.DefaultText = ""
            tbSecondName.DisabledState.BorderColor = Drawing.Color.FromArgb(208, 208, 208)
            tbSecondName.DisabledState.FillColor = Drawing.Color.FromArgb(226, 226, 226)
            tbSecondName.DisabledState.ForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbSecondName.DisabledState.Parent = tbSecondName
            tbSecondName.DisabledState.PlaceholderForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbSecondName.FocusedState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbSecondName.FocusedState.Parent = tbSecondName
            tbSecondName.HoverState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbSecondName.HoverState.Parent = tbSecondName
            tbSecondName.Location = New Drawing.Point(328, 18)
            tbSecondName.Margin = New Windows.Forms.Padding(4, 4, 4, 4)
            tbSecondName.Name = "tbSecondName"
            tbSecondName.PasswordChar = ChrW(0)
            tbSecondName.PlaceholderText = ""
            tbSecondName.SelectedText = ""
            tbSecondName.ShadowDecoration.Parent = tbSecondName
            tbSecondName.Size = New Drawing.Size(154, 31)
            tbSecondName.TabIndex = 12
            ' 
            ' tbFirstName
            ' 
            tbFirstName.Cursor = Windows.Forms.Cursors.IBeam
            tbFirstName.DefaultText = ""
            tbFirstName.DisabledState.BorderColor = Drawing.Color.FromArgb(208, 208, 208)
            tbFirstName.DisabledState.FillColor = Drawing.Color.FromArgb(226, 226, 226)
            tbFirstName.DisabledState.ForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbFirstName.DisabledState.Parent = tbFirstName
            tbFirstName.DisabledState.PlaceholderForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbFirstName.FocusedState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbFirstName.FocusedState.Parent = tbFirstName
            tbFirstName.HoverState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbFirstName.HoverState.Parent = tbFirstName
            tbFirstName.Location = New Drawing.Point(145, 18)
            tbFirstName.Margin = New Windows.Forms.Padding(4, 4, 4, 4)
            tbFirstName.Name = "tbFirstName"
            tbFirstName.PasswordChar = ChrW(0)
            tbFirstName.PlaceholderText = ""
            tbFirstName.SelectedText = ""
            tbFirstName.ShadowDecoration.Parent = tbFirstName
            tbFirstName.Size = New Drawing.Size(154, 31)
            tbFirstName.TabIndex = 11
            ' 
            ' pictureBox2
            ' 
            pictureBox2.Image = Global.DVLD_Project.Properties.Resources.icons8_person_64
            pictureBox2.Location = New Drawing.Point(76, 18)
            pictureBox2.Name = "pictureBox2"
            pictureBox2.Size = New Drawing.Size(33, 31)
            pictureBox2.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox2.TabIndex = 10
            pictureBox2.TabStop = False
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label4.Location = New Drawing.Point(13, 25)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(44, 16)
            label4.TabIndex = 9
            label4.Text = "Name"
            ' 
            ' lblPersonID
            ' 
            lblPersonID.AutoSize = True
            lblPersonID.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblPersonID.Location = New Drawing.Point(128, 67)
            lblPersonID.Name = "lblPersonID"
            lblPersonID.Size = New Drawing.Size(30, 16)
            lblPersonID.TabIndex = 7
            lblPersonID.Text = "N/A"
            ' 
            ' errorProvider1
            ' 
            errorProvider1.ContainerControl = Me
            ' 
            ' pictureBox1
            ' 
            pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), Drawing.Image)
            pictureBox1.Location = New Drawing.Point(89, 60)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(33, 31)
            pictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox1.TabIndex = 8
            pictureBox1.TabStop = False
            ' 
            ' openFileDialog1
            ' 
            openFileDialog1.FileName = "openFileDialog1"
            ' 
            ' Form3
            ' 
            AutoScaleDimensions = New Drawing.SizeF(8F, 16F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(882, 465)
            Controls.Add(pictureBox1)
            Controls.Add(lblPersonID)
            Controls.Add(groupBox1)
            Controls.Add(label2)
            Controls.Add(label1)
            Name = "Form3"
            StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            Text = "Form3"
            AddHandler Load, New EventHandler(AddressOf Form3_Load)
            groupBox1.ResumeLayout(False)
            groupBox1.PerformLayout()
            CType(pbProfile, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox10, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox9, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox8, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox7, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox6, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox5, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox4, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox3, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox2, ComponentModel.ISupportInitialize).EndInit()
            CType(errorProvider1, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private label1 As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
        Private groupBox1 As Windows.Forms.GroupBox
        Private rbFemal As Windows.Forms.RadioButton
        Private rbMale As Windows.Forms.RadioButton
        Private pictureBox4 As Windows.Forms.PictureBox
        Private label6 As Windows.Forms.Label
        Private tbNationalID As Guna.UI2.WinForms.Guna2TextBox
        Private tbLastName As Guna.UI2.WinForms.Guna2TextBox
        Private pictureBox3 As Windows.Forms.PictureBox
        Private tbThirdName As Guna.UI2.WinForms.Guna2TextBox
        Private label5 As Windows.Forms.Label
        Private tbSecondName As Guna.UI2.WinForms.Guna2TextBox
        Private tbFirstName As Guna.UI2.WinForms.Guna2TextBox
        Private pictureBox2 As Windows.Forms.PictureBox
        Private label4 As Windows.Forms.Label
        Private lblPersonID As Windows.Forms.Label
        Private pictureBox1 As Windows.Forms.PictureBox
        Private pbProfile As Windows.Forms.PictureBox
        Private tbAddreass As Guna.UI2.WinForms.Guna2TextBox
        Private pictureBox10 As Windows.Forms.PictureBox
        Private label11 As Windows.Forms.Label
        Private cbCountry As Guna.UI2.WinForms.Guna2ComboBox
        Private pictureBox9 As Windows.Forms.PictureBox
        Private label10 As Windows.Forms.Label
        Private dtpBirthDate As Windows.Forms.DateTimePicker
        Private pictureBox8 As Windows.Forms.PictureBox
        Private label9 As Windows.Forms.Label
        Private tbPhone As Guna.UI2.WinForms.Guna2TextBox
        Private pictureBox7 As Windows.Forms.PictureBox
        Private label8 As Windows.Forms.Label
        Private tbEmail As Guna.UI2.WinForms.Guna2TextBox
        Private pictureBox6 As Windows.Forms.PictureBox
        Private label7 As Windows.Forms.Label
        Private pictureBox5 As Windows.Forms.PictureBox
        Private guna2Button2 As Guna.UI2.WinForms.Guna2Button
        Private guna2Button1 As Guna.UI2.WinForms.Guna2Button
        Private linkLabel1 As Windows.Forms.LinkLabel
        Private linkLabel2 As Windows.Forms.LinkLabel
        Private errorProvider1 As Windows.Forms.ErrorProvider
        Private openFileDialog1 As Windows.Forms.OpenFileDialog
    End Class
End Namespace
