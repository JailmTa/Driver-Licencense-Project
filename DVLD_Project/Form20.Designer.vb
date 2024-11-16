Namespace DVLD_Project
    Partial Class Form20
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
            pictureBox1 = New Windows.Forms.PictureBox()
            guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
            guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
            reTakeExam1 = New ReTakeExam()
            testMainInformations1 = New TestMainInformations()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' pictureBox1
            ' 
            pictureBox1.Image = Global.DVLD_Project.Properties.Resources.icons8_eye_64
            pictureBox1.Location = New Drawing.Point(115, 12)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(246, 76)
            pictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox1.TabIndex = 17
            pictureBox1.TabStop = False
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
            guna2Button2.Location = New Drawing.Point(208, 767)
            guna2Button2.Name = "guna2Button2"
            guna2Button2.ShadowDecoration.Parent = guna2Button2
            guna2Button2.Size = New Drawing.Size(119, 42)
            guna2Button2.TabIndex = 42
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
            guna2Button1.Location = New Drawing.Point(341, 767)
            guna2Button1.Name = "guna2Button1"
            guna2Button1.ShadowDecoration.Parent = guna2Button1
            guna2Button1.Size = New Drawing.Size(119, 42)
            guna2Button1.TabIndex = 41
            guna2Button1.Text = "Sava"
            guna2Button1.TextAlign = Windows.Forms.HorizontalAlignment.Right
            AddHandler guna2Button1.Click, New EventHandler(AddressOf guna2Button1_Click)
            ' 
            ' reTakeExam1
            ' 
            reTakeExam1.Location = New Drawing.Point(5, 568)
            reTakeExam1.Name = "reTakeExam1"
            reTakeExam1.Size = New Drawing.Size(455, 136)
            reTakeExam1.TabIndex = 19
            ' 
            ' testMainInformations1
            ' 
            testMainInformations1.Location = New Drawing.Point(6, 94)
            testMainInformations1.Name = "testMainInformations1"
            testMainInformations1.Size = New Drawing.Size(455, 486)
            testMainInformations1.TabIndex = 18
            AddHandler testMainInformations1.Load, New EventHandler(AddressOf testMainInformations1_Load)
            ' 
            ' Form20
            ' 
            AutoScaleDimensions = New Drawing.SizeF(8F, 16F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(472, 821)
            Controls.Add(guna2Button2)
            Controls.Add(guna2Button1)
            Controls.Add(reTakeExam1)
            Controls.Add(testMainInformations1)
            Controls.Add(pictureBox1)
            Name = "Form20"
            Text = "Form20"
            AddHandler Load, New EventHandler(AddressOf Form20_Load)
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)

        End Sub

#End Region

        Private testMainInformations1 As TestMainInformations
        Private pictureBox1 As Windows.Forms.PictureBox
        Private reTakeExam1 As ReTakeExam
        Private guna2Button2 As Guna.UI2.WinForms.Guna2Button
        Private guna2Button1 As Guna.UI2.WinForms.Guna2Button
    End Class
End Namespace
