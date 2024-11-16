Namespace DVLD_Project
    Partial Class Form9
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
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form9))
            tbConPassWord = New Guna.UI2.WinForms.Guna2TextBox()
            label3 = New Windows.Forms.Label()
            tbPassWord = New Guna.UI2.WinForms.Guna2TextBox()
            label1 = New Windows.Forms.Label()
            lblUserID = New Windows.Forms.Label()
            label2 = New Windows.Forms.Label()
            tbUserName = New Guna.UI2.WinForms.Guna2TextBox()
            label4 = New Windows.Forms.Label()
            label5 = New Windows.Forms.Label()
            tbOldPassWord = New Guna.UI2.WinForms.Guna2TextBox()
            label6 = New Windows.Forms.Label()
            label7 = New Windows.Forms.Label()
            ckbActive = New Windows.Forms.CheckBox()
            errorProvider1 = New Windows.Forms.ErrorProvider(components)
            pictureBox6 = New Windows.Forms.PictureBox()
            pictureBox5 = New Windows.Forms.PictureBox()
            guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
            guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
            pictureBox4 = New Windows.Forms.PictureBox()
            pictureBox3 = New Windows.Forms.PictureBox()
            pictureBox1 = New Windows.Forms.PictureBox()
            pictureBox2 = New Windows.Forms.PictureBox()
            CType(errorProvider1, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox6, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox5, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox4, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox3, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox2, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' tbConPassWord
            ' 
            tbConPassWord.Cursor = Windows.Forms.Cursors.IBeam
            tbConPassWord.DefaultText = ""
            tbConPassWord.DisabledState.BorderColor = Drawing.Color.FromArgb(208, 208, 208)
            tbConPassWord.DisabledState.FillColor = Drawing.Color.FromArgb(226, 226, 226)
            tbConPassWord.DisabledState.ForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbConPassWord.DisabledState.Parent = tbConPassWord
            tbConPassWord.DisabledState.PlaceholderForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbConPassWord.FocusedState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbConPassWord.FocusedState.Parent = tbConPassWord
            tbConPassWord.HoverState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbConPassWord.HoverState.Parent = tbConPassWord
            tbConPassWord.Location = New Drawing.Point(171, 271)
            tbConPassWord.Margin = New Windows.Forms.Padding(4, 4, 4, 4)
            tbConPassWord.Name = "tbConPassWord"
            tbConPassWord.PasswordChar = ChrW(0)
            tbConPassWord.PlaceholderText = ""
            tbConPassWord.SelectedText = ""
            tbConPassWord.ShadowDecoration.Parent = tbConPassWord
            tbConPassWord.Size = New Drawing.Size(154, 31)
            tbConPassWord.TabIndex = 52
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label3.Location = New Drawing.Point(12, 286)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(80, 16)
            label3.TabIndex = 50
            label3.Text = "CPassWord"
            ' 
            ' tbPassWord
            ' 
            tbPassWord.Cursor = Windows.Forms.Cursors.IBeam
            tbPassWord.DefaultText = ""
            tbPassWord.DisabledState.BorderColor = Drawing.Color.FromArgb(208, 208, 208)
            tbPassWord.DisabledState.FillColor = Drawing.Color.FromArgb(226, 226, 226)
            tbPassWord.DisabledState.ForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbPassWord.DisabledState.Parent = tbPassWord
            tbPassWord.DisabledState.PlaceholderForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbPassWord.FocusedState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbPassWord.FocusedState.Parent = tbPassWord
            tbPassWord.HoverState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbPassWord.HoverState.Parent = tbPassWord
            tbPassWord.Location = New Drawing.Point(171, 228)
            tbPassWord.Margin = New Windows.Forms.Padding(4, 4, 4, 4)
            tbPassWord.Name = "tbPassWord"
            tbPassWord.PasswordChar = ChrW(0)
            tbPassWord.PlaceholderText = ""
            tbPassWord.SelectedText = ""
            tbPassWord.ShadowDecoration.Parent = tbPassWord
            tbPassWord.Size = New Drawing.Size(154, 31)
            tbPassWord.TabIndex = 49
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label1.Location = New Drawing.Point(12, 243)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(71, 16)
            label1.TabIndex = 47
            label1.Text = "PassWord"
            ' 
            ' lblUserID
            ' 
            lblUserID.AutoSize = True
            lblUserID.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblUserID.Location = New Drawing.Point(168, 121)
            lblUserID.Name = "lblUserID"
            lblUserID.Size = New Drawing.Size(30, 16)
            lblUserID.TabIndex = 42
            lblUserID.Text = "N/A"
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label2.Location = New Drawing.Point(12, 125)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(49, 16)
            label2.TabIndex = 41
            label2.Text = "UserID"
            ' 
            ' tbUserName
            ' 
            tbUserName.Cursor = Windows.Forms.Cursors.IBeam
            tbUserName.DefaultText = ""
            tbUserName.DisabledState.BorderColor = Drawing.Color.FromArgb(208, 208, 208)
            tbUserName.DisabledState.FillColor = Drawing.Color.FromArgb(226, 226, 226)
            tbUserName.DisabledState.ForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbUserName.DisabledState.Parent = tbUserName
            tbUserName.DisabledState.PlaceholderForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbUserName.FocusedState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbUserName.FocusedState.Parent = tbUserName
            tbUserName.HoverState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbUserName.HoverState.Parent = tbUserName
            tbUserName.Location = New Drawing.Point(171, 150)
            tbUserName.Margin = New Windows.Forms.Padding(4, 4, 4, 4)
            tbUserName.Name = "tbUserName"
            tbUserName.PasswordChar = ChrW(0)
            tbUserName.PlaceholderText = ""
            tbUserName.SelectedText = ""
            tbUserName.ShadowDecoration.Parent = tbUserName
            tbUserName.Size = New Drawing.Size(154, 31)
            tbUserName.TabIndex = 46
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label4.Location = New Drawing.Point(12, 165)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(76, 16)
            label4.TabIndex = 44
            label4.Text = "User Name"
            ' 
            ' label5
            ' 
            label5.AutoSize = True
            label5.Font = New Drawing.Font("Microsoft Sans Serif", 18F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label5.ForeColor = Drawing.Color.FromArgb(255, 128, 128)
            label5.Location = New Drawing.Point(35, 21)
            label5.Name = "label5"
            label5.Size = New Drawing.Size(266, 36)
            label5.TabIndex = 55
            label5.Text = "Change PassWord"
            AddHandler label5.Click, New EventHandler(AddressOf label5_Click)
            ' 
            ' tbOldPassWord
            ' 
            tbOldPassWord.Cursor = Windows.Forms.Cursors.IBeam
            tbOldPassWord.DefaultText = ""
            tbOldPassWord.DisabledState.BorderColor = Drawing.Color.FromArgb(208, 208, 208)
            tbOldPassWord.DisabledState.FillColor = Drawing.Color.FromArgb(226, 226, 226)
            tbOldPassWord.DisabledState.ForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbOldPassWord.DisabledState.Parent = tbOldPassWord
            tbOldPassWord.DisabledState.PlaceholderForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbOldPassWord.FocusedState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbOldPassWord.FocusedState.Parent = tbOldPassWord
            tbOldPassWord.HoverState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbOldPassWord.HoverState.Parent = tbOldPassWord
            tbOldPassWord.Location = New Drawing.Point(172, 190)
            tbOldPassWord.Margin = New Windows.Forms.Padding(4, 4, 4, 4)
            tbOldPassWord.Name = "tbOldPassWord"
            tbOldPassWord.PasswordChar = ChrW(0)
            tbOldPassWord.PlaceholderText = ""
            tbOldPassWord.SelectedText = ""
            tbOldPassWord.ShadowDecoration.Parent = tbOldPassWord
            tbOldPassWord.Size = New Drawing.Size(154, 31)
            tbOldPassWord.TabIndex = 58
            AddHandler tbOldPassWord.TextChanged, New EventHandler(AddressOf tbOldPassWord_TextChanged)
            AddHandler tbOldPassWord.Validating, New ComponentModel.CancelEventHandler(AddressOf tbOldPassWord_Validating)
            ' 
            ' label6
            ' 
            label6.AutoSize = True
            label6.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label6.Location = New Drawing.Point(13, 205)
            label6.Name = "label6"
            label6.Size = New Drawing.Size(81, 16)
            label6.TabIndex = 56
            label6.Text = "OPassWord"
            ' 
            ' label7
            ' 
            label7.AutoSize = True
            label7.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label7.Location = New Drawing.Point(13, 328)
            label7.Name = "label7"
            label7.Size = New Drawing.Size(53, 16)
            label7.TabIndex = 60
            label7.Text = "IsActiv?"
            ' 
            ' ckbActive
            ' 
            ckbActive.AutoSize = True
            ckbActive.Location = New Drawing.Point(172, 324)
            ckbActive.Name = "ckbActive"
            ckbActive.Size = New Drawing.Size(66, 20)
            ckbActive.TabIndex = 59
            ckbActive.Text = "Active"
            ckbActive.UseVisualStyleBackColor = True
            ' 
            ' errorProvider1
            ' 
            errorProvider1.ContainerControl = Me
            ' 
            ' pictureBox6
            ' 
            pictureBox6.Image = Global.DVLD_Project.Properties.Resources.icons8_asking_64
            pictureBox6.Location = New Drawing.Point(103, 313)
            pictureBox6.Name = "pictureBox6"
            pictureBox6.Size = New Drawing.Size(33, 31)
            pictureBox6.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox6.TabIndex = 61
            pictureBox6.TabStop = False
            ' 
            ' pictureBox5
            ' 
            pictureBox5.Image = CType(resources.GetObject("pictureBox5.Image"), Drawing.Image)
            pictureBox5.Location = New Drawing.Point(103, 190)
            pictureBox5.Name = "pictureBox5"
            pictureBox5.Size = New Drawing.Size(33, 31)
            pictureBox5.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox5.TabIndex = 57
            pictureBox5.TabStop = False
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
            guna2Button2.Location = New Drawing.Point(16, 358)
            guna2Button2.Name = "guna2Button2"
            guna2Button2.ShadowDecoration.Parent = guna2Button2
            guna2Button2.Size = New Drawing.Size(119, 42)
            guna2Button2.TabIndex = 54
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
            guna2Button1.Location = New Drawing.Point(182, 358)
            guna2Button1.Name = "guna2Button1"
            guna2Button1.ShadowDecoration.Parent = guna2Button1
            guna2Button1.Size = New Drawing.Size(119, 42)
            guna2Button1.TabIndex = 53
            guna2Button1.Text = "Sava"
            guna2Button1.TextAlign = Windows.Forms.HorizontalAlignment.Right
            AddHandler guna2Button1.Click, New EventHandler(AddressOf guna2Button1_Click)
            ' 
            ' pictureBox4
            ' 
            pictureBox4.Image = CType(resources.GetObject("pictureBox4.Image"), Drawing.Image)
            pictureBox4.Location = New Drawing.Point(102, 271)
            pictureBox4.Name = "pictureBox4"
            pictureBox4.Size = New Drawing.Size(33, 31)
            pictureBox4.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox4.TabIndex = 51
            pictureBox4.TabStop = False
            ' 
            ' pictureBox3
            ' 
            pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), Drawing.Image)
            pictureBox3.Location = New Drawing.Point(102, 228)
            pictureBox3.Name = "pictureBox3"
            pictureBox3.Size = New Drawing.Size(33, 31)
            pictureBox3.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox3.TabIndex = 48
            pictureBox3.TabStop = False
            ' 
            ' pictureBox1
            ' 
            pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), Drawing.Image)
            pictureBox1.Location = New Drawing.Point(102, 110)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(33, 31)
            pictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox1.TabIndex = 43
            pictureBox1.TabStop = False
            ' 
            ' pictureBox2
            ' 
            pictureBox2.Image = Global.DVLD_Project.Properties.Resources.icons8_person_64
            pictureBox2.Location = New Drawing.Point(102, 150)
            pictureBox2.Name = "pictureBox2"
            pictureBox2.Size = New Drawing.Size(33, 31)
            pictureBox2.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox2.TabIndex = 45
            pictureBox2.TabStop = False
            ' 
            ' Form9
            ' 
            AutoScaleDimensions = New Drawing.SizeF(8F, 16F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(344, 412)
            Controls.Add(label7)
            Controls.Add(pictureBox6)
            Controls.Add(ckbActive)
            Controls.Add(tbOldPassWord)
            Controls.Add(label6)
            Controls.Add(pictureBox5)
            Controls.Add(label5)
            Controls.Add(guna2Button2)
            Controls.Add(guna2Button1)
            Controls.Add(tbConPassWord)
            Controls.Add(label3)
            Controls.Add(tbPassWord)
            Controls.Add(label1)
            Controls.Add(lblUserID)
            Controls.Add(label2)
            Controls.Add(tbUserName)
            Controls.Add(label4)
            Controls.Add(pictureBox4)
            Controls.Add(pictureBox3)
            Controls.Add(pictureBox1)
            Controls.Add(pictureBox2)
            Name = "Form9"
            Text = "Chenge PassWord"
            AddHandler Load, New EventHandler(AddressOf Form9_Load)
            CType(errorProvider1, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox6, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox5, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox4, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox3, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox2, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private guna2Button2 As Guna.UI2.WinForms.Guna2Button
        Private guna2Button1 As Guna.UI2.WinForms.Guna2Button
        Private tbConPassWord As Guna.UI2.WinForms.Guna2TextBox
        Private label3 As Windows.Forms.Label
        Private tbPassWord As Guna.UI2.WinForms.Guna2TextBox
        Private label1 As Windows.Forms.Label
        Private lblUserID As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
        Private tbUserName As Guna.UI2.WinForms.Guna2TextBox
        Private label4 As Windows.Forms.Label
        Private pictureBox4 As Windows.Forms.PictureBox
        Private pictureBox3 As Windows.Forms.PictureBox
        Private pictureBox1 As Windows.Forms.PictureBox
        Private pictureBox2 As Windows.Forms.PictureBox
        Private label5 As Windows.Forms.Label
        Private tbOldPassWord As Guna.UI2.WinForms.Guna2TextBox
        Private label6 As Windows.Forms.Label
        Private pictureBox5 As Windows.Forms.PictureBox
        Private label7 As Windows.Forms.Label
        Private pictureBox6 As Windows.Forms.PictureBox
        Private ckbActive As Windows.Forms.CheckBox
        Private errorProvider1 As Windows.Forms.ErrorProvider
    End Class
End Namespace
