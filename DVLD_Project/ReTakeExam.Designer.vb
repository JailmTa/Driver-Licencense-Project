Namespace DVLD_Project
    Partial Class ReTakeExam
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

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ReTakeExam))
            groupBox1 = New Windows.Forms.GroupBox()
            lblAppID = New Windows.Forms.Label()
            label2 = New Windows.Forms.Label()
            pictureBox1 = New Windows.Forms.PictureBox()
            pictureBox2 = New Windows.Forms.PictureBox()
            lblFeesR = New Windows.Forms.Label()
            label3 = New Windows.Forms.Label()
            pictureBox3 = New Windows.Forms.PictureBox()
            lblFeesT = New Windows.Forms.Label()
            label5 = New Windows.Forms.Label()
            groupBox1.SuspendLayout()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox2, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox3, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' groupBox1
            ' 
            groupBox1.Controls.Add(pictureBox3)
            groupBox1.Controls.Add(lblFeesT)
            groupBox1.Controls.Add(label5)
            groupBox1.Controls.Add(pictureBox2)
            groupBox1.Controls.Add(lblFeesR)
            groupBox1.Controls.Add(label3)
            groupBox1.Controls.Add(pictureBox1)
            groupBox1.Controls.Add(lblAppID)
            groupBox1.Controls.Add(label2)
            groupBox1.Location = New Drawing.Point(7, 11)
            groupBox1.Name = "groupBox1"
            groupBox1.Size = New Drawing.Size(441, 111)
            groupBox1.TabIndex = 9
            groupBox1.TabStop = False
            groupBox1.Text = "ReTake Test Details"
            ' 
            ' lblAppID
            ' 
            lblAppID.AutoSize = True
            lblAppID.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblAppID.Location = New Drawing.Point(141, 29)
            lblAppID.Name = "lblAppID"
            lblAppID.Size = New Drawing.Size(30, 16)
            lblAppID.TabIndex = 12
            lblAppID.Text = "N/A"
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label2.Location = New Drawing.Point(19, 29)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(85, 16)
            label2.TabIndex = 10
            label2.Text = "R.TestAppID"
            ' 
            ' pictureBox1
            ' 
            pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), Drawing.Image)
            pictureBox1.Location = New Drawing.Point(102, 22)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(33, 31)
            pictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox1.TabIndex = 13
            pictureBox1.TabStop = False
            ' 
            ' pictureBox2
            ' 
            pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), Drawing.Image)
            pictureBox2.Location = New Drawing.Point(102, 63)
            pictureBox2.Name = "pictureBox2"
            pictureBox2.Size = New Drawing.Size(33, 31)
            pictureBox2.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox2.TabIndex = 58
            pictureBox2.TabStop = False
            ' 
            ' lblFeesR
            ' 
            lblFeesR.AutoSize = True
            lblFeesR.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblFeesR.Location = New Drawing.Point(141, 70)
            lblFeesR.Name = "lblFeesR"
            lblFeesR.Size = New Drawing.Size(30, 16)
            lblFeesR.TabIndex = 57
            lblFeesR.Text = "N/A"
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label3.Location = New Drawing.Point(19, 70)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(76, 16)
            label3.TabIndex = 56
            label3.Text = "R.AppFees"
            ' 
            ' pictureBox3
            ' 
            pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), Drawing.Image)
            pictureBox3.Location = New Drawing.Point(329, 63)
            pictureBox3.Name = "pictureBox3"
            pictureBox3.Size = New Drawing.Size(33, 31)
            pictureBox3.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox3.TabIndex = 61
            pictureBox3.TabStop = False
            ' 
            ' lblFeesT
            ' 
            lblFeesT.AutoSize = True
            lblFeesT.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblFeesT.Location = New Drawing.Point(368, 70)
            lblFeesT.Name = "lblFeesT"
            lblFeesT.Size = New Drawing.Size(30, 16)
            lblFeesT.TabIndex = 60
            lblFeesT.Text = "N/A"
            ' 
            ' label5
            ' 
            label5.AutoSize = True
            label5.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label5.Location = New Drawing.Point(246, 70)
            label5.Name = "label5"
            label5.Size = New Drawing.Size(69, 16)
            label5.TabIndex = 59
            label5.Text = "TotalFees"
            ' 
            ' ReTakeExam
            ' 
            AutoScaleDimensions = New Drawing.SizeF(8F, 16F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            Controls.Add(groupBox1)
            Name = "ReTakeExam"
            Size = New Drawing.Size(455, 136)
            AddHandler Load, New EventHandler(AddressOf ReTakeExam_Load)
            groupBox1.ResumeLayout(False)
            groupBox1.PerformLayout()
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox2, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox3, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)

        End Sub

#End Region

        Private groupBox1 As Windows.Forms.GroupBox
        Private pictureBox1 As Windows.Forms.PictureBox
        Private lblAppID As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
        Private pictureBox3 As Windows.Forms.PictureBox
        Private lblFeesT As Windows.Forms.Label
        Private label5 As Windows.Forms.Label
        Private pictureBox2 As Windows.Forms.PictureBox
        Private lblFeesR As Windows.Forms.Label
        Private label3 As Windows.Forms.Label
    End Class
End Namespace
