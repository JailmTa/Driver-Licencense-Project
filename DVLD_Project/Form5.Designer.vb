Namespace DVLD_Project
    Partial Class Form5
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
            guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
            pictureBox1 = New Windows.Forms.PictureBox()
            guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
            guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
            guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
            tbPassWord = New Guna.UI2.WinForms.Guna2TextBox()
            label3 = New Windows.Forms.Label()
            tbUserName = New Guna.UI2.WinForms.Guna2TextBox()
            label2 = New Windows.Forms.Label()
            label1 = New Windows.Forms.Label()
            checkBox1 = New Windows.Forms.CheckBox()
            guna2CustomGradientPanel2.SuspendLayout()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' guna2CustomGradientPanel2
            ' 
            guna2CustomGradientPanel2.BackColor = Drawing.Color.Transparent
            guna2CustomGradientPanel2.Controls.Add(pictureBox1)
            guna2CustomGradientPanel2.Dock = Windows.Forms.DockStyle.Left
            guna2CustomGradientPanel2.FillColor = Drawing.Color.FromArgb(75, 75, 75)
            guna2CustomGradientPanel2.FillColor4 = Drawing.Color.FromArgb(75, 75, 75)
            guna2CustomGradientPanel2.Location = New Drawing.Point(0, 0)
            guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2"
            guna2CustomGradientPanel2.ShadowDecoration.Parent = guna2CustomGradientPanel2
            guna2CustomGradientPanel2.Size = New Drawing.Size(217, 336)
            guna2CustomGradientPanel2.TabIndex = 70
            ' 
            ' pictureBox1
            ' 
            pictureBox1.BackColor = Drawing.Color.Transparent
            pictureBox1.Image = Global.DVLD_Project.Properties.Resources.icons8_taxi_driver_641
            pictureBox1.Location = New Drawing.Point(3, 30)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(202, 232)
            pictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox1.TabIndex = 0
            pictureBox1.TabStop = False
            ' 
            ' guna2Elipse1
            ' 
            guna2Elipse1.BorderRadius = 20
            guna2Elipse1.TargetControl = guna2CustomGradientPanel2
            ' 
            ' guna2Button1
            ' 
            guna2Button1.AutoRoundedCorners = True
            guna2Button1.BackColor = Drawing.Color.Transparent
            guna2Button1.BorderRadius = 23
            guna2Button1.CheckedState.Parent = guna2Button1
            guna2Button1.CustomImages.Parent = guna2Button1
            guna2Button1.FillColor = Drawing.Color.FromArgb(165, 170, 132)
            guna2Button1.Font = New Drawing.Font("Segoe UI", 9F)
            guna2Button1.ForeColor = Drawing.Color.White
            guna2Button1.HoverState.Parent = guna2Button1
            guna2Button1.ImageAlign = Windows.Forms.HorizontalAlignment.Left
            guna2Button1.ImageSize = New Drawing.Size(30, 30)
            guna2Button1.Location = New Drawing.Point(355, 268)
            guna2Button1.Name = "guna2Button1"
            guna2Button1.ShadowDecoration.Parent = guna2Button1
            guna2Button1.Size = New Drawing.Size(154, 48)
            guna2Button1.TabIndex = 77
            guna2Button1.Text = "LogIn"
            AddHandler guna2Button1.Click, New EventHandler(AddressOf guna2Button1_Click)
            ' 
            ' guna2Button2
            ' 
            guna2Button2.AutoRoundedCorners = True
            guna2Button2.BackColor = Drawing.Color.Transparent
            guna2Button2.BorderRadius = 23
            guna2Button2.CheckedState.Parent = guna2Button2
            guna2Button2.CustomImages.Parent = guna2Button2
            guna2Button2.FillColor = Drawing.Color.FromArgb(165, 170, 132)
            guna2Button2.Font = New Drawing.Font("Segoe UI", 9F)
            guna2Button2.ForeColor = Drawing.Color.White
            guna2Button2.HoverState.Parent = guna2Button2
            guna2Button2.ImageAlign = Windows.Forms.HorizontalAlignment.Left
            guna2Button2.ImageSize = New Drawing.Size(30, 30)
            guna2Button2.Location = New Drawing.Point(565, 268)
            guna2Button2.Name = "guna2Button2"
            guna2Button2.ShadowDecoration.Parent = guna2Button2
            guna2Button2.Size = New Drawing.Size(154, 48)
            guna2Button2.TabIndex = 76
            guna2Button2.Text = "Sing Up"
            ' 
            ' tbPassWord
            ' 
            tbPassWord.AutoRoundedCorners = True
            tbPassWord.BorderColor = Drawing.Color.FromArgb(33, 58, 87)
            tbPassWord.BorderRadius = 20
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
            tbPassWord.Location = New Drawing.Point(355, 177)
            tbPassWord.Margin = New Windows.Forms.Padding(4, 4, 4, 4)
            tbPassWord.Name = "tbPassWord"
            tbPassWord.PasswordChar = "*"c
            tbPassWord.PlaceholderText = ""
            tbPassWord.SelectedText = ""
            tbPassWord.ShadowDecoration.Parent = tbPassWord
            tbPassWord.Size = New Drawing.Size(364, 42)
            tbPassWord.TabIndex = 75
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.Location = New Drawing.Point(248, 190)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(77, 16)
            label3.TabIndex = 74
            label3.Text = "PassWord :"
            ' 
            ' tbUserName
            ' 
            tbUserName.AutoRoundedCorners = True
            tbUserName.BorderColor = Drawing.Color.FromArgb(33, 58, 87)
            tbUserName.BorderRadius = 20
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
            tbUserName.Location = New Drawing.Point(355, 118)
            tbUserName.Margin = New Windows.Forms.Padding(4, 4, 4, 4)
            tbUserName.Name = "tbUserName"
            tbUserName.PasswordChar = ChrW(0)
            tbUserName.PlaceholderText = ""
            tbUserName.SelectedText = ""
            tbUserName.ShadowDecoration.Parent = tbUserName
            tbUserName.Size = New Drawing.Size(364, 42)
            tbUserName.TabIndex = 73
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.Location = New Drawing.Point(248, 131)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(85, 16)
            label2.TabIndex = 72
            label2.Text = "User Name : "
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Font = New Drawing.Font("Microsoft Sans Serif", 18F)
            label1.Location = New Drawing.Point(455, 30)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(168, 36)
            label1.TabIndex = 71
            label1.Text = "LogIn Page"
            ' 
            ' checkBox1
            ' 
            checkBox1.AutoSize = True
            checkBox1.Location = New Drawing.Point(461, 242)
            checkBox1.Name = "checkBox1"
            checkBox1.Size = New Drawing.Size(122, 20)
            checkBox1.TabIndex = 78
            checkBox1.Text = "Remember Me."
            checkBox1.UseVisualStyleBackColor = True
            AddHandler checkBox1.CheckedChanged, New EventHandler(AddressOf checkBox1_CheckedChanged)
            ' 
            ' Form5
            ' 
            AcceptButton = guna2Button1
            AutoScaleDimensions = New Drawing.SizeF(8F, 16F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            BackColor = Drawing.Color.FromArgb(130, 130, 130)
            ClientSize = New Drawing.Size(723, 336)
            Controls.Add(checkBox1)
            Controls.Add(guna2CustomGradientPanel2)
            Controls.Add(guna2Button1)
            Controls.Add(guna2Button2)
            Controls.Add(tbPassWord)
            Controls.Add(label3)
            Controls.Add(tbUserName)
            Controls.Add(label2)
            Controls.Add(label1)
            Name = "Form5"
            Text = "Form5"
            AddHandler Load, New EventHandler(AddressOf Form5_Load)
            guna2CustomGradientPanel2.ResumeLayout(False)
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
        Private pictureBox1 As Windows.Forms.PictureBox
        Private guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
        Private guna2Button1 As Guna.UI2.WinForms.Guna2Button
        Private guna2Button2 As Guna.UI2.WinForms.Guna2Button
        Private tbPassWord As Guna.UI2.WinForms.Guna2TextBox
        Private label3 As Windows.Forms.Label
        Private tbUserName As Guna.UI2.WinForms.Guna2TextBox
        Private label2 As Windows.Forms.Label
        Private label1 As Windows.Forms.Label
        Private checkBox1 As Windows.Forms.CheckBox
    End Class
End Namespace
