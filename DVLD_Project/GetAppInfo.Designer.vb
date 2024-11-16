Namespace DVLD_Project
    Partial Class GetAppInfo
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
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(GetAppInfo))
            groupBox1 = New Windows.Forms.GroupBox()
            lblExamsDone = New Windows.Forms.Label()
            label5 = New Windows.Forms.Label()
            linkLabel1 = New Windows.Forms.LinkLabel()
            lblClassName = New Windows.Forms.Label()
            label3 = New Windows.Forms.Label()
            lblAppID = New Windows.Forms.Label()
            label2 = New Windows.Forms.Label()
            pictureBox4 = New Windows.Forms.PictureBox()
            pictureBox3 = New Windows.Forms.PictureBox()
            pictureBox2 = New Windows.Forms.PictureBox()
            pictureBox1 = New Windows.Forms.PictureBox()
            groupBox1.SuspendLayout()
            CType(pictureBox4, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox3, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox2, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' groupBox1
            ' 
            groupBox1.Controls.Add(pictureBox4)
            groupBox1.Controls.Add(lblExamsDone)
            groupBox1.Controls.Add(label5)
            groupBox1.Controls.Add(linkLabel1)
            groupBox1.Controls.Add(pictureBox3)
            groupBox1.Controls.Add(pictureBox2)
            groupBox1.Controls.Add(lblClassName)
            groupBox1.Controls.Add(label3)
            groupBox1.Controls.Add(pictureBox1)
            groupBox1.Controls.Add(lblAppID)
            groupBox1.Controls.Add(label2)
            groupBox1.Location = New Drawing.Point(3, 9)
            groupBox1.Name = "groupBox1"
            groupBox1.Size = New Drawing.Size(727, 140)
            groupBox1.TabIndex = 0
            groupBox1.TabStop = False
            groupBox1.Text = "Applcation Informations"
            AddHandler groupBox1.Enter, New EventHandler(AddressOf groupBox1_Enter)
            ' 
            ' lblExamsDone
            ' 
            lblExamsDone.AutoSize = True
            lblExamsDone.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblExamsDone.Location = New Drawing.Point(523, 99)
            lblExamsDone.Name = "lblExamsDone"
            lblExamsDone.Size = New Drawing.Size(30, 16)
            lblExamsDone.TabIndex = 31
            lblExamsDone.Text = "N/A"
            ' 
            ' label5
            ' 
            label5.AutoSize = True
            label5.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label5.Location = New Drawing.Point(365, 99)
            label5.Name = "label5"
            label5.Size = New Drawing.Size(84, 16)
            label5.TabIndex = 30
            label5.Text = "Exams Done"
            AddHandler label5.Click, New EventHandler(AddressOf label5_Click)
            ' 
            ' linkLabel1
            ' 
            linkLabel1.AutoSize = True
            linkLabel1.Location = New Drawing.Point(195, 99)
            linkLabel1.Name = "linkLabel1"
            linkLabel1.Size = New Drawing.Size(89, 16)
            linkLabel1.TabIndex = 29
            linkLabel1.TabStop = True
            linkLabel1.Text = "Issue Lisence"
            ' 
            ' lblClassName
            ' 
            lblClassName.AutoSize = True
            lblClassName.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblClassName.Location = New Drawing.Point(523, 36)
            lblClassName.Name = "lblClassName"
            lblClassName.Size = New Drawing.Size(30, 16)
            lblClassName.TabIndex = 26
            lblClassName.Text = "N/A"
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label3.Location = New Drawing.Point(365, 36)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(81, 16)
            label3.TabIndex = 25
            label3.Text = "Class Name"
            ' 
            ' lblAppID
            ' 
            lblAppID.AutoSize = True
            lblAppID.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblAppID.Location = New Drawing.Point(195, 36)
            lblAppID.Name = "lblAppID"
            lblAppID.Size = New Drawing.Size(30, 16)
            lblAppID.TabIndex = 23
            lblAppID.Text = "N/A"
            AddHandler lblAppID.Click, New EventHandler(AddressOf lblTypeID_Click)
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label2.Location = New Drawing.Point(37, 36)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(84, 16)
            label2.TabIndex = 22
            label2.Text = "ApplcationID"
            ' 
            ' pictureBox4
            ' 
            pictureBox4.Image = Global.DVLD_Project.Properties.Resources.icons8_done_64
            pictureBox4.Location = New Drawing.Point(455, 92)
            pictureBox4.Name = "pictureBox4"
            pictureBox4.Size = New Drawing.Size(33, 31)
            pictureBox4.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox4.TabIndex = 32
            pictureBox4.TabStop = False
            ' 
            ' pictureBox3
            ' 
            pictureBox3.Image = Global.DVLD_Project.Properties.Resources.icons8_license_100
            pictureBox3.Location = New Drawing.Point(127, 92)
            pictureBox3.Name = "pictureBox3"
            pictureBox3.Size = New Drawing.Size(33, 31)
            pictureBox3.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox3.TabIndex = 28
            pictureBox3.TabStop = False
            ' 
            ' pictureBox2
            ' 
            pictureBox2.Image = Global.DVLD_Project.Properties.Resources.icons8_type_64
            pictureBox2.Location = New Drawing.Point(455, 29)
            pictureBox2.Name = "pictureBox2"
            pictureBox2.Size = New Drawing.Size(33, 31)
            pictureBox2.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox2.TabIndex = 27
            pictureBox2.TabStop = False
            ' 
            ' pictureBox1
            ' 
            pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), Drawing.Image)
            pictureBox1.Location = New Drawing.Point(127, 29)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(33, 31)
            pictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox1.TabIndex = 24
            pictureBox1.TabStop = False
            AddHandler pictureBox1.Click, New EventHandler(AddressOf pictureBox1_Click)
            ' 
            ' GetAppInfo
            ' 
            AutoScaleDimensions = New Drawing.SizeF(8F, 16F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            Controls.Add(groupBox1)
            Name = "GetAppInfo"
            Size = New Drawing.Size(743, 152)
            AddHandler Load, New EventHandler(AddressOf GetAppInfo_Load)
            groupBox1.ResumeLayout(False)
            groupBox1.PerformLayout()
            CType(pictureBox4, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox3, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox2, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)

        End Sub

#End Region

        Private groupBox1 As Windows.Forms.GroupBox
        Private pictureBox1 As Windows.Forms.PictureBox
        Private lblAppID As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
        Private pictureBox4 As Windows.Forms.PictureBox
        Private lblExamsDone As Windows.Forms.Label
        Private label5 As Windows.Forms.Label
        Private linkLabel1 As Windows.Forms.LinkLabel
        Private pictureBox3 As Windows.Forms.PictureBox
        Private pictureBox2 As Windows.Forms.PictureBox
        Private lblClassName As Windows.Forms.Label
        Private label3 As Windows.Forms.Label
    End Class
End Namespace
