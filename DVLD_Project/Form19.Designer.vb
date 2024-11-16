Namespace DVLD_Project
    Partial Class Form19
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
            label1 = New Windows.Forms.Label()
            testMainInformations1 = New TestMainInformations()
            label2 = New Windows.Forms.Label()
            pictureBox2 = New Windows.Forms.PictureBox()
            pictureBox1 = New Windows.Forms.PictureBox()
            rbPass = New Windows.Forms.RadioButton()
            rbFail = New Windows.Forms.RadioButton()
            label3 = New Windows.Forms.Label()
            guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
            guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
            guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
            CType(pictureBox2, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Font = New Drawing.Font("Microsoft Sans Serif", 18F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label1.ForeColor = Drawing.Color.FromArgb(255, 128, 128)
            label1.Location = New Drawing.Point(154, 92)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(181, 36)
            label1.TabIndex = 15
            label1.Text = "Vision Exam"
            ' 
            ' testMainInformations1
            ' 
            testMainInformations1.Location = New Drawing.Point(12, 94)
            testMainInformations1.Name = "testMainInformations1"
            testMainInformations1.Size = New Drawing.Size(455, 486)
            testMainInformations1.TabIndex = 16
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label2.Location = New Drawing.Point(36, 583)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(45, 16)
            label2.TabIndex = 17
            label2.Text = "Result"
            ' 
            ' pictureBox2
            ' 
            pictureBox2.Image = Global.DVLD_Project.Properties.Resources.icons8_result_64
            pictureBox2.Location = New Drawing.Point(99, 576)
            pictureBox2.Name = "pictureBox2"
            pictureBox2.Size = New Drawing.Size(33, 31)
            pictureBox2.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox2.TabIndex = 19
            pictureBox2.TabStop = False
            ' 
            ' pictureBox1
            ' 
            pictureBox1.Image = Global.DVLD_Project.Properties.Resources.icons8_eye_64
            pictureBox1.Location = New Drawing.Point(121, 12)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(246, 76)
            pictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox1.TabIndex = 14
            pictureBox1.TabStop = False
            ' 
            ' rbPass
            ' 
            rbPass.AutoSize = True
            rbPass.Location = New Drawing.Point(138, 586)
            rbPass.Name = "rbPass"
            rbPass.Size = New Drawing.Size(59, 20)
            rbPass.TabIndex = 20
            rbPass.TabStop = True
            rbPass.Text = "Pass"
            rbPass.UseVisualStyleBackColor = True
            ' 
            ' rbFail
            ' 
            rbFail.AutoSize = True
            rbFail.Location = New Drawing.Point(203, 587)
            rbFail.Name = "rbFail"
            rbFail.Size = New Drawing.Size(50, 20)
            rbFail.TabIndex = 21
            rbFail.TabStop = True
            rbFail.Text = "Fail"
            rbFail.UseVisualStyleBackColor = True
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label3.Location = New Drawing.Point(36, 629)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(43, 16)
            label3.TabIndex = 22
            label3.Text = "Notes"
            ' 
            ' guna2TextBox1
            ' 
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
            guna2TextBox1.Location = New Drawing.Point(99, 629)
            guna2TextBox1.Margin = New Windows.Forms.Padding(4, 4, 4, 4)
            guna2TextBox1.Multiline = True
            guna2TextBox1.Name = "guna2TextBox1"
            guna2TextBox1.PasswordChar = ChrW(0)
            guna2TextBox1.PlaceholderText = ""
            guna2TextBox1.SelectedText = ""
            guna2TextBox1.ShadowDecoration.Parent = guna2TextBox1
            guna2TextBox1.Size = New Drawing.Size(360, 133)
            guna2TextBox1.TabIndex = 23
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
            guna2Button2.Location = New Drawing.Point(207, 771)
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
            guna2Button1.Location = New Drawing.Point(340, 771)
            guna2Button1.Name = "guna2Button1"
            guna2Button1.ShadowDecoration.Parent = guna2Button1
            guna2Button1.Size = New Drawing.Size(119, 42)
            guna2Button1.TabIndex = 39
            guna2Button1.Text = "Sava"
            guna2Button1.TextAlign = Windows.Forms.HorizontalAlignment.Right
            AddHandler guna2Button1.Click, New EventHandler(AddressOf guna2Button1_Click)
            ' 
            ' Form19
            ' 
            AutoScaleDimensions = New Drawing.SizeF(8F, 16F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(472, 821)
            Controls.Add(guna2Button2)
            Controls.Add(guna2Button1)
            Controls.Add(guna2TextBox1)
            Controls.Add(label3)
            Controls.Add(rbFail)
            Controls.Add(rbPass)
            Controls.Add(pictureBox2)
            Controls.Add(label2)
            Controls.Add(testMainInformations1)
            Controls.Add(label1)
            Controls.Add(pictureBox1)
            Name = "Form19"
            Text = "Form19"
            AddHandler Load, New EventHandler(AddressOf Form19_Load)
            CType(pictureBox2, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private label1 As Windows.Forms.Label
        Private pictureBox1 As Windows.Forms.PictureBox
        Private testMainInformations1 As TestMainInformations
        Private pictureBox2 As Windows.Forms.PictureBox
        Private label2 As Windows.Forms.Label
        Private rbPass As Windows.Forms.RadioButton
        Private rbFail As Windows.Forms.RadioButton
        Private label3 As Windows.Forms.Label
        Private guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
        Private guna2Button2 As Guna.UI2.WinForms.Guna2Button
        Private guna2Button1 As Guna.UI2.WinForms.Guna2Button
    End Class
End Namespace
