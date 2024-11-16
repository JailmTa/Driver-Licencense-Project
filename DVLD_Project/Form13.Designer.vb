Namespace DVLD_Project
    Partial Class Form13
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
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form13))
            tbFees = New Guna.UI2.WinForms.Guna2TextBox()
            label3 = New Windows.Forms.Label()
            lblTypeID = New Windows.Forms.Label()
            label2 = New Windows.Forms.Label()
            tbTestName = New Guna.UI2.WinForms.Guna2TextBox()
            label4 = New Windows.Forms.Label()
            label1 = New Windows.Forms.Label()
            guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
            guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
            pictureBox3 = New Windows.Forms.PictureBox()
            pictureBox1 = New Windows.Forms.PictureBox()
            pictureBox2 = New Windows.Forms.PictureBox()
            tbNote = New Guna.UI2.WinForms.Guna2TextBox()
            pictureBox4 = New Windows.Forms.PictureBox()
            label5 = New Windows.Forms.Label()
            CType(pictureBox3, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox2, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox4, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' tbFees
            ' 
            tbFees.Cursor = Windows.Forms.Cursors.IBeam
            tbFees.DefaultText = ""
            tbFees.DisabledState.BorderColor = Drawing.Color.FromArgb(208, 208, 208)
            tbFees.DisabledState.FillColor = Drawing.Color.FromArgb(226, 226, 226)
            tbFees.DisabledState.ForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbFees.DisabledState.Parent = tbFees
            tbFees.DisabledState.PlaceholderForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbFees.FocusedState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbFees.FocusedState.Parent = tbFees
            tbFees.HoverState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbFees.HoverState.Parent = tbFees
            tbFees.Location = New Drawing.Point(193, 316)
            tbFees.Margin = New Windows.Forms.Padding(4, 4, 4, 4)
            tbFees.Name = "tbFees"
            tbFees.PasswordChar = ChrW(0)
            tbFees.PlaceholderText = ""
            tbFees.SelectedText = ""
            tbFees.ShadowDecoration.Parent = tbFees
            tbFees.Size = New Drawing.Size(301, 31)
            tbFees.TabIndex = 50
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label3.Location = New Drawing.Point(61, 322)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(38, 16)
            label3.TabIndex = 48
            label3.Text = "Fees"
            ' 
            ' lblTypeID
            ' 
            lblTypeID.AutoSize = True
            lblTypeID.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblTypeID.Location = New Drawing.Point(190, 71)
            lblTypeID.Name = "lblTypeID"
            lblTypeID.Size = New Drawing.Size(30, 16)
            lblTypeID.TabIndex = 43
            lblTypeID.Text = "N/A"
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label2.Location = New Drawing.Point(59, 71)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(47, 16)
            label2.TabIndex = 42
            label2.Text = "TestID"
            ' 
            ' tbTestName
            ' 
            tbTestName.Cursor = Windows.Forms.Cursors.IBeam
            tbTestName.DefaultText = ""
            tbTestName.DisabledState.BorderColor = Drawing.Color.FromArgb(208, 208, 208)
            tbTestName.DisabledState.FillColor = Drawing.Color.FromArgb(226, 226, 226)
            tbTestName.DisabledState.ForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbTestName.DisabledState.Parent = tbTestName
            tbTestName.DisabledState.PlaceholderForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbTestName.FocusedState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbTestName.FocusedState.Parent = tbTestName
            tbTestName.HoverState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbTestName.HoverState.Parent = tbTestName
            tbTestName.Location = New Drawing.Point(193, 112)
            tbTestName.Margin = New Windows.Forms.Padding(4, 4, 4, 4)
            tbTestName.Name = "tbTestName"
            tbTestName.PasswordChar = ChrW(0)
            tbTestName.PlaceholderText = ""
            tbTestName.SelectedText = ""
            tbTestName.ShadowDecoration.Parent = tbTestName
            tbTestName.Size = New Drawing.Size(301, 31)
            tbTestName.TabIndex = 47
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label4.Location = New Drawing.Point(61, 119)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(44, 16)
            label4.TabIndex = 45
            label4.Text = "Name"
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Font = New Drawing.Font("Microsoft Sans Serif", 18F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label1.ForeColor = Drawing.Color.FromArgb(255, 128, 128)
            label1.Location = New Drawing.Point(205, 9)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(147, 36)
            label1.TabIndex = 41
            label1.Text = "Edit Tests"
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
            guna2Button2.Location = New Drawing.Point(211, 365)
            guna2Button2.Name = "guna2Button2"
            guna2Button2.ShadowDecoration.Parent = guna2Button2
            guna2Button2.Size = New Drawing.Size(119, 42)
            guna2Button2.TabIndex = 52
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
            guna2Button1.Location = New Drawing.Point(344, 365)
            guna2Button1.Name = "guna2Button1"
            guna2Button1.ShadowDecoration.Parent = guna2Button1
            guna2Button1.Size = New Drawing.Size(119, 42)
            guna2Button1.TabIndex = 51
            guna2Button1.Text = "Sava"
            guna2Button1.TextAlign = Windows.Forms.HorizontalAlignment.Right
            AddHandler guna2Button1.Click, New EventHandler(AddressOf guna2Button1_Click)
            ' 
            ' pictureBox3
            ' 
            pictureBox3.Image = Global.DVLD_Project.Properties.Resources.icons8_money_64
            pictureBox3.Location = New Drawing.Point(124, 315)
            pictureBox3.Name = "pictureBox3"
            pictureBox3.Size = New Drawing.Size(33, 31)
            pictureBox3.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox3.TabIndex = 49
            pictureBox3.TabStop = False
            ' 
            ' pictureBox1
            ' 
            pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), Drawing.Image)
            pictureBox1.Location = New Drawing.Point(122, 64)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(33, 31)
            pictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox1.TabIndex = 44
            pictureBox1.TabStop = False
            ' 
            ' pictureBox2
            ' 
            pictureBox2.Image = Global.DVLD_Project.Properties.Resources.icons8_type_64
            pictureBox2.Location = New Drawing.Point(124, 112)
            pictureBox2.Name = "pictureBox2"
            pictureBox2.Size = New Drawing.Size(33, 31)
            pictureBox2.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox2.TabIndex = 46
            pictureBox2.TabStop = False
            ' 
            ' tbNote
            ' 
            tbNote.Cursor = Windows.Forms.Cursors.IBeam
            tbNote.DefaultText = ""
            tbNote.DisabledState.BorderColor = Drawing.Color.FromArgb(208, 208, 208)
            tbNote.DisabledState.FillColor = Drawing.Color.FromArgb(226, 226, 226)
            tbNote.DisabledState.ForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbNote.DisabledState.Parent = tbNote
            tbNote.DisabledState.PlaceholderForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbNote.FocusedState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbNote.FocusedState.Parent = tbNote
            tbNote.HoverState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbNote.HoverState.Parent = tbNote
            tbNote.Location = New Drawing.Point(193, 151)
            tbNote.Margin = New Windows.Forms.Padding(4, 4, 4, 4)
            tbNote.Multiline = True
            tbNote.Name = "tbNote"
            tbNote.PasswordChar = ChrW(0)
            tbNote.PlaceholderText = ""
            tbNote.SelectedText = ""
            tbNote.ShadowDecoration.Parent = tbNote
            tbNote.Size = New Drawing.Size(301, 148)
            tbNote.TabIndex = 55
            ' 
            ' pictureBox4
            ' 
            pictureBox4.Image = Global.DVLD_Project.Properties.Resources.icons8_type_64
            pictureBox4.Location = New Drawing.Point(122, 160)
            pictureBox4.Name = "pictureBox4"
            pictureBox4.Size = New Drawing.Size(33, 31)
            pictureBox4.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox4.TabIndex = 54
            pictureBox4.TabStop = False
            ' 
            ' label5
            ' 
            label5.AutoSize = True
            label5.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label5.Location = New Drawing.Point(59, 167)
            label5.Name = "label5"
            label5.Size = New Drawing.Size(43, 16)
            label5.TabIndex = 53
            label5.Text = "Notes"
            ' 
            ' Form13
            ' 
            AutoScaleDimensions = New Drawing.SizeF(8F, 16F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(552, 412)
            Controls.Add(tbNote)
            Controls.Add(pictureBox4)
            Controls.Add(label5)
            Controls.Add(guna2Button2)
            Controls.Add(guna2Button1)
            Controls.Add(tbFees)
            Controls.Add(pictureBox3)
            Controls.Add(label3)
            Controls.Add(pictureBox1)
            Controls.Add(lblTypeID)
            Controls.Add(label2)
            Controls.Add(tbTestName)
            Controls.Add(pictureBox2)
            Controls.Add(label4)
            Controls.Add(label1)
            Name = "Form13"
            Text = "Form13"
            CType(pictureBox3, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox2, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox4, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private guna2Button2 As Guna.UI2.WinForms.Guna2Button
        Private guna2Button1 As Guna.UI2.WinForms.Guna2Button
        Private tbFees As Guna.UI2.WinForms.Guna2TextBox
        Private pictureBox3 As Windows.Forms.PictureBox
        Private label3 As Windows.Forms.Label
        Private pictureBox1 As Windows.Forms.PictureBox
        Private lblTypeID As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
        Private tbTestName As Guna.UI2.WinForms.Guna2TextBox
        Private pictureBox2 As Windows.Forms.PictureBox
        Private label4 As Windows.Forms.Label
        Private label1 As Windows.Forms.Label
        Private tbNote As Guna.UI2.WinForms.Guna2TextBox
        Private pictureBox4 As Windows.Forms.PictureBox
        Private label5 As Windows.Forms.Label
    End Class
End Namespace
