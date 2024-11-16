Namespace DVLD_Project
    Partial Class Form11
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
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form11))
            label1 = New Windows.Forms.Label()
            lblTypeID = New Windows.Forms.Label()
            label2 = New Windows.Forms.Label()
            tbTypeName = New Guna.UI2.WinForms.Guna2TextBox()
            label4 = New Windows.Forms.Label()
            tbFees = New Guna.UI2.WinForms.Guna2TextBox()
            label3 = New Windows.Forms.Label()
            pictureBox3 = New Windows.Forms.PictureBox()
            pictureBox1 = New Windows.Forms.PictureBox()
            pictureBox2 = New Windows.Forms.PictureBox()
            guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
            guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
            CType(pictureBox3, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox2, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Font = New Drawing.Font("Microsoft Sans Serif", 18F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label1.ForeColor = Drawing.Color.FromArgb(255, 128, 128)
            label1.Location = New Drawing.Point(219, 9)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(156, 36)
            label1.TabIndex = 18
            label1.Text = "Edit Types"
            ' 
            ' lblTypeID
            ' 
            lblTypeID.AutoSize = True
            lblTypeID.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblTypeID.Location = New Drawing.Point(143, 69)
            lblTypeID.Name = "lblTypeID"
            lblTypeID.Size = New Drawing.Size(30, 16)
            lblTypeID.TabIndex = 20
            lblTypeID.Text = "N/A"
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label2.Location = New Drawing.Point(12, 69)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(52, 16)
            label2.TabIndex = 19
            label2.Text = "TypeID"
            ' 
            ' tbTypeName
            ' 
            tbTypeName.Cursor = Windows.Forms.Cursors.IBeam
            tbTypeName.DefaultText = ""
            tbTypeName.DisabledState.BorderColor = Drawing.Color.FromArgb(208, 208, 208)
            tbTypeName.DisabledState.FillColor = Drawing.Color.FromArgb(226, 226, 226)
            tbTypeName.DisabledState.ForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbTypeName.DisabledState.Parent = tbTypeName
            tbTypeName.DisabledState.PlaceholderForeColor = Drawing.Color.FromArgb(138, 138, 138)
            tbTypeName.FocusedState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbTypeName.FocusedState.Parent = tbTypeName
            tbTypeName.HoverState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            tbTypeName.HoverState.Parent = tbTypeName
            tbTypeName.Location = New Drawing.Point(146, 110)
            tbTypeName.Margin = New Windows.Forms.Padding(4, 4, 4, 4)
            tbTypeName.Name = "tbTypeName"
            tbTypeName.PasswordChar = ChrW(0)
            tbTypeName.PlaceholderText = ""
            tbTypeName.SelectedText = ""
            tbTypeName.ShadowDecoration.Parent = tbTypeName
            tbTypeName.Size = New Drawing.Size(301, 31)
            tbTypeName.TabIndex = 24
            AddHandler tbTypeName.TextChanged, New EventHandler(AddressOf tbFirstName_TextChanged)
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label4.Location = New Drawing.Point(14, 117)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(44, 16)
            label4.TabIndex = 22
            label4.Text = "Name"
            AddHandler label4.Click, New EventHandler(AddressOf label4_Click)
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
            tbFees.Location = New Drawing.Point(146, 159)
            tbFees.Margin = New Windows.Forms.Padding(4, 4, 4, 4)
            tbFees.Name = "tbFees"
            tbFees.PasswordChar = ChrW(0)
            tbFees.PlaceholderText = ""
            tbFees.SelectedText = ""
            tbFees.ShadowDecoration.Parent = tbFees
            tbFees.Size = New Drawing.Size(301, 31)
            tbFees.TabIndex = 27
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label3.Location = New Drawing.Point(14, 165)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(38, 16)
            label3.TabIndex = 25
            label3.Text = "Fees"
            ' 
            ' pictureBox3
            ' 
            pictureBox3.Image = Global.DVLD_Project.Properties.Resources.icons8_money_64
            pictureBox3.Location = New Drawing.Point(77, 158)
            pictureBox3.Name = "pictureBox3"
            pictureBox3.Size = New Drawing.Size(33, 31)
            pictureBox3.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox3.TabIndex = 26
            pictureBox3.TabStop = False
            ' 
            ' pictureBox1
            ' 
            pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), Drawing.Image)
            pictureBox1.Location = New Drawing.Point(75, 62)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(33, 31)
            pictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox1.TabIndex = 21
            pictureBox1.TabStop = False
            ' 
            ' pictureBox2
            ' 
            pictureBox2.Image = Global.DVLD_Project.Properties.Resources.icons8_type_64
            pictureBox2.Location = New Drawing.Point(77, 110)
            pictureBox2.Name = "pictureBox2"
            pictureBox2.Size = New Drawing.Size(33, 31)
            pictureBox2.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox2.TabIndex = 23
            pictureBox2.TabStop = False
            AddHandler pictureBox2.Click, New EventHandler(AddressOf pictureBox2_Click)
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
            guna2Button2.Location = New Drawing.Point(164, 208)
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
            guna2Button1.Location = New Drawing.Point(297, 208)
            guna2Button1.Name = "guna2Button1"
            guna2Button1.ShadowDecoration.Parent = guna2Button1
            guna2Button1.Size = New Drawing.Size(119, 42)
            guna2Button1.TabIndex = 39
            guna2Button1.Text = "Sava"
            guna2Button1.TextAlign = Windows.Forms.HorizontalAlignment.Right
            AddHandler guna2Button1.Click, New EventHandler(AddressOf guna2Button1_Click)
            ' 
            ' Form11
            ' 
            AutoScaleDimensions = New Drawing.SizeF(8F, 16F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(552, 262)
            Controls.Add(guna2Button2)
            Controls.Add(guna2Button1)
            Controls.Add(tbFees)
            Controls.Add(pictureBox3)
            Controls.Add(label3)
            Controls.Add(pictureBox1)
            Controls.Add(lblTypeID)
            Controls.Add(label2)
            Controls.Add(tbTypeName)
            Controls.Add(pictureBox2)
            Controls.Add(label4)
            Controls.Add(label1)
            Name = "Form11"
            Text = "Form11"
            AddHandler Load, New EventHandler(AddressOf Form11_Load)
            CType(pictureBox3, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox2, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private label1 As Windows.Forms.Label
        Private pictureBox1 As Windows.Forms.PictureBox
        Private lblTypeID As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
        Private tbTypeName As Guna.UI2.WinForms.Guna2TextBox
        Private pictureBox2 As Windows.Forms.PictureBox
        Private label4 As Windows.Forms.Label
        Private tbFees As Guna.UI2.WinForms.Guna2TextBox
        Private pictureBox3 As Windows.Forms.PictureBox
        Private label3 As Windows.Forms.Label
        Private guna2Button2 As Guna.UI2.WinForms.Guna2Button
        Private guna2Button1 As Guna.UI2.WinForms.Guna2Button
    End Class
End Namespace
