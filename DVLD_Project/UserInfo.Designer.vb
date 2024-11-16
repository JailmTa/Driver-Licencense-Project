Namespace DVLD_Project
    Partial Class UserInfo
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
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(UserInfo))
            groupBox1 = New Windows.Forms.GroupBox()
            lblActive = New Windows.Forms.Label()
            pictureBox2 = New Windows.Forms.PictureBox()
            label3 = New Windows.Forms.Label()
            lblUesrName = New Windows.Forms.Label()
            pictureBox18 = New Windows.Forms.PictureBox()
            label18 = New Windows.Forms.Label()
            pictureBox1 = New Windows.Forms.PictureBox()
            lblUserID = New Windows.Forms.Label()
            label2 = New Windows.Forms.Label()
            linkLabel1 = New Windows.Forms.LinkLabel()
            groupBox1.SuspendLayout()
            CType(pictureBox2, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox18, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' groupBox1
            ' 
            groupBox1.Controls.Add(linkLabel1)
            groupBox1.Controls.Add(lblActive)
            groupBox1.Controls.Add(pictureBox2)
            groupBox1.Controls.Add(label3)
            groupBox1.Controls.Add(lblUesrName)
            groupBox1.Controls.Add(pictureBox18)
            groupBox1.Controls.Add(label18)
            groupBox1.Controls.Add(pictureBox1)
            groupBox1.Controls.Add(lblUserID)
            groupBox1.Controls.Add(label2)
            groupBox1.Location = New Drawing.Point(3, 11)
            groupBox1.Name = "groupBox1"
            groupBox1.Size = New Drawing.Size(733, 77)
            groupBox1.TabIndex = 0
            groupBox1.TabStop = False
            groupBox1.Text = "User Informations"
            AddHandler groupBox1.Enter, New EventHandler(AddressOf groupBox1_Enter)
            ' 
            ' lblActive
            ' 
            lblActive.AutoSize = True
            lblActive.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblActive.Location = New Drawing.Point(660, 38)
            lblActive.Name = "lblActive"
            lblActive.Size = New Drawing.Size(30, 16)
            lblActive.TabIndex = 62
            lblActive.Text = "N/A"
            ' 
            ' pictureBox2
            ' 
            pictureBox2.Image = Global.DVLD_Project.Properties.Resources.icons8_asking_64
            pictureBox2.Location = New Drawing.Point(621, 31)
            pictureBox2.Name = "pictureBox2"
            pictureBox2.Size = New Drawing.Size(33, 31)
            pictureBox2.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox2.TabIndex = 61
            pictureBox2.TabStop = False
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label3.Location = New Drawing.Point(558, 38)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(54, 16)
            label3.TabIndex = 60
            label3.Text = "IsActive"
            ' 
            ' lblUesrName
            ' 
            lblUesrName.AutoSize = True
            lblUesrName.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblUesrName.Location = New Drawing.Point(399, 38)
            lblUesrName.Name = "lblUesrName"
            lblUesrName.Size = New Drawing.Size(30, 16)
            lblUesrName.TabIndex = 59
            lblUesrName.Text = "N/A"
            ' 
            ' pictureBox18
            ' 
            pictureBox18.Image = Global.DVLD_Project.Properties.Resources.icons8_person_64
            pictureBox18.Location = New Drawing.Point(360, 31)
            pictureBox18.Name = "pictureBox18"
            pictureBox18.Size = New Drawing.Size(33, 31)
            pictureBox18.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox18.TabIndex = 58
            pictureBox18.TabStop = False
            ' 
            ' label18
            ' 
            label18.AutoSize = True
            label18.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label18.Location = New Drawing.Point(281, 38)
            label18.Name = "label18"
            label18.Size = New Drawing.Size(73, 16)
            label18.TabIndex = 57
            label18.Text = "UserName"
            ' 
            ' pictureBox1
            ' 
            pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), Drawing.Image)
            pictureBox1.Location = New Drawing.Point(69, 31)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(33, 31)
            pictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox1.TabIndex = 56
            pictureBox1.TabStop = False
            ' 
            ' lblUserID
            ' 
            lblUserID.AutoSize = True
            lblUserID.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblUserID.Location = New Drawing.Point(108, 38)
            lblUserID.Name = "lblUserID"
            lblUserID.Size = New Drawing.Size(30, 16)
            lblUserID.TabIndex = 55
            lblUserID.Text = "N/A"
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label2.Location = New Drawing.Point(6, 38)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(49, 16)
            label2.TabIndex = 54
            label2.Text = "UserID"
            ' 
            ' linkLabel1
            ' 
            linkLabel1.AutoSize = True
            linkLabel1.Location = New Drawing.Point(573, 12)
            linkLabel1.Name = "linkLabel1"
            linkLabel1.Size = New Drawing.Size(159, 16)
            linkLabel1.TabIndex = 63
            linkLabel1.TabStop = True
            linkLabel1.Text = "Update User Informations"
            AddHandler linkLabel1.LinkClicked, New Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf linkLabel1_LinkClicked)
            ' 
            ' UserInfo
            ' 
            AutoScaleDimensions = New Drawing.SizeF(8F, 16F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            Controls.Add(groupBox1)
            Name = "UserInfo"
            Size = New Drawing.Size(739, 91)
            AddHandler Load, New EventHandler(AddressOf UserInfo_Load)
            groupBox1.ResumeLayout(False)
            groupBox1.PerformLayout()
            CType(pictureBox2, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox18, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)

        End Sub

#End Region

        Private groupBox1 As Windows.Forms.GroupBox
        Private lblUesrName As Windows.Forms.Label
        Private pictureBox18 As Windows.Forms.PictureBox
        Private label18 As Windows.Forms.Label
        Private pictureBox1 As Windows.Forms.PictureBox
        Private lblUserID As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
        Private lblActive As Windows.Forms.Label
        Private pictureBox2 As Windows.Forms.PictureBox
        Private label3 As Windows.Forms.Label
        Private linkLabel1 As Windows.Forms.LinkLabel
    End Class
End Namespace
