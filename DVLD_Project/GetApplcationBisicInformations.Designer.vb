Namespace DVLD_Project
    Partial Class GetApplcationBisicInformations
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
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(GetApplcationBisicInformations))
            groupBox1 = New Windows.Forms.GroupBox()
            lblStutesDate = New Windows.Forms.Label()
            pictureBox2 = New Windows.Forms.PictureBox()
            label5 = New Windows.Forms.Label()
            linkLabel1 = New Windows.Forms.LinkLabel()
            lblDate = New Windows.Forms.Label()
            lblName = New Windows.Forms.Label()
            lblType = New Windows.Forms.Label()
            lblFees = New Windows.Forms.Label()
            lblStatues = New Windows.Forms.Label()
            lblCreatedBy = New Windows.Forms.Label()
            pictureBox11 = New Windows.Forms.PictureBox()
            label3 = New Windows.Forms.Label()
            pictureBox13 = New Windows.Forms.PictureBox()
            label13 = New Windows.Forms.Label()
            pictureBox14 = New Windows.Forms.PictureBox()
            label14 = New Windows.Forms.Label()
            pictureBox15 = New Windows.Forms.PictureBox()
            label15 = New Windows.Forms.Label()
            pictureBox16 = New Windows.Forms.PictureBox()
            label16 = New Windows.Forms.Label()
            pictureBox17 = New Windows.Forms.PictureBox()
            label17 = New Windows.Forms.Label()
            pictureBox1 = New Windows.Forms.PictureBox()
            lblAppID = New Windows.Forms.Label()
            label2 = New Windows.Forms.Label()
            label1 = New Windows.Forms.Label()
            groupBox1.SuspendLayout()
            CType(pictureBox2, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox11, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox13, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox14, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox15, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox16, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox17, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' groupBox1
            ' 
            groupBox1.Controls.Add(lblStutesDate)
            groupBox1.Controls.Add(pictureBox2)
            groupBox1.Controls.Add(label5)
            groupBox1.Controls.Add(linkLabel1)
            groupBox1.Controls.Add(lblDate)
            groupBox1.Controls.Add(lblName)
            groupBox1.Controls.Add(lblType)
            groupBox1.Controls.Add(lblFees)
            groupBox1.Controls.Add(lblStatues)
            groupBox1.Controls.Add(lblCreatedBy)
            groupBox1.Controls.Add(pictureBox11)
            groupBox1.Controls.Add(label3)
            groupBox1.Controls.Add(pictureBox13)
            groupBox1.Controls.Add(label13)
            groupBox1.Controls.Add(pictureBox14)
            groupBox1.Controls.Add(label14)
            groupBox1.Controls.Add(pictureBox15)
            groupBox1.Controls.Add(label15)
            groupBox1.Controls.Add(pictureBox16)
            groupBox1.Controls.Add(label16)
            groupBox1.Controls.Add(pictureBox17)
            groupBox1.Controls.Add(label17)
            groupBox1.Controls.Add(pictureBox1)
            groupBox1.Controls.Add(lblAppID)
            groupBox1.Controls.Add(label2)
            groupBox1.Location = New Drawing.Point(5, 67)
            groupBox1.Name = "groupBox1"
            groupBox1.Size = New Drawing.Size(728, 295)
            groupBox1.TabIndex = 6
            groupBox1.TabStop = False
            groupBox1.Text = "Applcation Details"
            ' 
            ' lblStutesDate
            ' 
            lblStutesDate.AutoSize = True
            lblStutesDate.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblStutesDate.Location = New Drawing.Point(587, 84)
            lblStutesDate.Name = "lblStutesDate"
            lblStutesDate.Size = New Drawing.Size(30, 16)
            lblStutesDate.TabIndex = 62
            lblStutesDate.Text = "N/A"
            ' 
            ' pictureBox2
            ' 
            pictureBox2.Image = Global.DVLD_Project.Properties.Resources.icons8_date_64
            pictureBox2.Location = New Drawing.Point(548, 77)
            pictureBox2.Name = "pictureBox2"
            pictureBox2.Size = New Drawing.Size(33, 31)
            pictureBox2.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox2.TabIndex = 61
            pictureBox2.TabStop = False
            ' 
            ' label5
            ' 
            label5.AutoSize = True
            label5.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label5.Location = New Drawing.Point(473, 84)
            label5.Name = "label5"
            label5.Size = New Drawing.Size(76, 16)
            label5.TabIndex = 60
            label5.Text = "Status Date"
            ' 
            ' linkLabel1
            ' 
            linkLabel1.AutoSize = True
            linkLabel1.Location = New Drawing.Point(545, 257)
            linkLabel1.Name = "linkLabel1"
            linkLabel1.Size = New Drawing.Size(129, 16)
            linkLabel1.TabIndex = 59
            linkLabel1.TabStop = True
            linkLabel1.Text = "UpDate Informations"
            AddHandler linkLabel1.LinkClicked, New Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf linkLabel1_LinkClicked)
            ' 
            ' lblDate
            ' 
            lblDate.AutoSize = True
            lblDate.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblDate.Location = New Drawing.Point(587, 29)
            lblDate.Name = "lblDate"
            lblDate.Size = New Drawing.Size(30, 16)
            lblDate.TabIndex = 58
            lblDate.Text = "N/A"
            ' 
            ' lblName
            ' 
            lblName.AutoSize = True
            lblName.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblName.Location = New Drawing.Point(121, 249)
            lblName.Name = "lblName"
            lblName.Size = New Drawing.Size(30, 16)
            lblName.TabIndex = 57
            lblName.Text = "N/A"
            ' 
            ' lblType
            ' 
            lblType.AutoSize = True
            lblType.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblType.Location = New Drawing.Point(121, 194)
            lblType.Name = "lblType"
            lblType.Size = New Drawing.Size(30, 16)
            lblType.TabIndex = 56
            lblType.Text = "N/A"
            ' 
            ' lblFees
            ' 
            lblFees.AutoSize = True
            lblFees.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblFees.Location = New Drawing.Point(121, 139)
            lblFees.Name = "lblFees"
            lblFees.Size = New Drawing.Size(30, 16)
            lblFees.TabIndex = 55
            lblFees.Text = "N/A"
            ' 
            ' lblStatues
            ' 
            lblStatues.AutoSize = True
            lblStatues.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblStatues.Location = New Drawing.Point(121, 84)
            lblStatues.Name = "lblStatues"
            lblStatues.Size = New Drawing.Size(30, 16)
            lblStatues.TabIndex = 54
            lblStatues.Text = "N/A"
            ' 
            ' lblCreatedBy
            ' 
            lblCreatedBy.AutoSize = True
            lblCreatedBy.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblCreatedBy.Location = New Drawing.Point(587, 139)
            lblCreatedBy.Name = "lblCreatedBy"
            lblCreatedBy.Size = New Drawing.Size(30, 16)
            lblCreatedBy.TabIndex = 51
            lblCreatedBy.Text = "N/A"
            ' 
            ' pictureBox11
            ' 
            pictureBox11.Image = Global.DVLD_Project.Properties.Resources.icons8_person_64
            pictureBox11.Location = New Drawing.Point(82, 242)
            pictureBox11.Name = "pictureBox11"
            pictureBox11.Size = New Drawing.Size(33, 31)
            pictureBox11.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox11.TabIndex = 49
            pictureBox11.TabStop = False
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label3.Location = New Drawing.Point(19, 249)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(63, 16)
            label3.TabIndex = 48
            label3.Text = "Applicant"
            ' 
            ' pictureBox13
            ' 
            pictureBox13.Image = Global.DVLD_Project.Properties.Resources.icons8_date_64
            pictureBox13.Location = New Drawing.Point(548, 22)
            pictureBox13.Name = "pictureBox13"
            pictureBox13.Size = New Drawing.Size(33, 31)
            pictureBox13.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox13.TabIndex = 45
            pictureBox13.TabStop = False
            ' 
            ' label13
            ' 
            label13.AutoSize = True
            label13.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label13.Location = New Drawing.Point(473, 29)
            label13.Name = "label13"
            label13.Size = New Drawing.Size(36, 16)
            label13.TabIndex = 44
            label13.Text = "Date"
            ' 
            ' pictureBox14
            ' 
            pictureBox14.Image = Global.DVLD_Project.Properties.Resources.icons8_person_64__1_
            pictureBox14.Location = New Drawing.Point(548, 132)
            pictureBox14.Name = "pictureBox14"
            pictureBox14.Size = New Drawing.Size(33, 31)
            pictureBox14.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox14.TabIndex = 43
            pictureBox14.TabStop = False
            ' 
            ' label14
            ' 
            label14.AutoSize = True
            label14.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label14.Location = New Drawing.Point(473, 139)
            label14.Name = "label14"
            label14.Size = New Drawing.Size(74, 16)
            label14.TabIndex = 42
            label14.Text = "Created By"
            ' 
            ' pictureBox15
            ' 
            pictureBox15.Image = Global.DVLD_Project.Properties.Resources.icons8_type_64
            pictureBox15.Location = New Drawing.Point(82, 187)
            pictureBox15.Name = "pictureBox15"
            pictureBox15.Size = New Drawing.Size(33, 31)
            pictureBox15.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox15.TabIndex = 41
            pictureBox15.TabStop = False
            ' 
            ' label15
            ' 
            label15.AutoSize = True
            label15.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label15.Location = New Drawing.Point(19, 194)
            label15.Name = "label15"
            label15.Size = New Drawing.Size(39, 16)
            label15.TabIndex = 40
            label15.Text = "Type"
            ' 
            ' pictureBox16
            ' 
            pictureBox16.Image = Global.DVLD_Project.Properties.Resources.icons8_money_64
            pictureBox16.Location = New Drawing.Point(82, 132)
            pictureBox16.Name = "pictureBox16"
            pictureBox16.Size = New Drawing.Size(33, 31)
            pictureBox16.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox16.TabIndex = 39
            pictureBox16.TabStop = False
            ' 
            ' label16
            ' 
            label16.AutoSize = True
            label16.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label16.Location = New Drawing.Point(19, 139)
            label16.Name = "label16"
            label16.Size = New Drawing.Size(38, 16)
            label16.TabIndex = 38
            label16.Text = "Fees"
            ' 
            ' pictureBox17
            ' 
            pictureBox17.Image = CType(resources.GetObject("pictureBox17.Image"), Drawing.Image)
            pictureBox17.Location = New Drawing.Point(82, 77)
            pictureBox17.Name = "pictureBox17"
            pictureBox17.Size = New Drawing.Size(33, 31)
            pictureBox17.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox17.TabIndex = 37
            pictureBox17.TabStop = False
            ' 
            ' label17
            ' 
            label17.AutoSize = True
            label17.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label17.Location = New Drawing.Point(19, 84)
            label17.Name = "label17"
            label17.Size = New Drawing.Size(52, 16)
            label17.TabIndex = 36
            label17.Text = "Statues"
            ' 
            ' pictureBox1
            ' 
            pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), Drawing.Image)
            pictureBox1.Location = New Drawing.Point(82, 22)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(33, 31)
            pictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox1.TabIndex = 13
            pictureBox1.TabStop = False
            ' 
            ' lblAppID
            ' 
            lblAppID.AutoSize = True
            lblAppID.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblAppID.Location = New Drawing.Point(121, 29)
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
            label2.Size = New Drawing.Size(20, 16)
            label2.TabIndex = 10
            label2.Text = "ID"
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Font = New Drawing.Font("Microsoft Sans Serif", 18F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label1.ForeColor = Drawing.Color.FromArgb(255, 128, 128)
            label1.Location = New Drawing.Point(238, 10)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(262, 36)
            label1.TabIndex = 5
            label1.Text = "Application Details"
            ' 
            ' GetApplcationBisicInformations
            ' 
            AutoScaleDimensions = New Drawing.SizeF(8F, 16F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            Controls.Add(groupBox1)
            Controls.Add(label1)
            Name = "GetApplcationBisicInformations"
            Size = New Drawing.Size(739, 373)
            AddHandler Load, New EventHandler(AddressOf GetApplcationBisicInformations_Load)
            groupBox1.ResumeLayout(False)
            groupBox1.PerformLayout()
            CType(pictureBox2, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox11, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox13, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox14, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox15, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox16, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox17, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private groupBox1 As Windows.Forms.GroupBox
        Private linkLabel1 As Windows.Forms.LinkLabel
        Private lblDate As Windows.Forms.Label
        Private lblName As Windows.Forms.Label
        Private lblType As Windows.Forms.Label
        Private lblFees As Windows.Forms.Label
        Private lblStatues As Windows.Forms.Label
        Private lblCreatedBy As Windows.Forms.Label
        Private pictureBox11 As Windows.Forms.PictureBox
        Private label3 As Windows.Forms.Label
        Private pictureBox13 As Windows.Forms.PictureBox
        Private label13 As Windows.Forms.Label
        Private pictureBox14 As Windows.Forms.PictureBox
        Private label14 As Windows.Forms.Label
        Private pictureBox15 As Windows.Forms.PictureBox
        Private label15 As Windows.Forms.Label
        Private pictureBox16 As Windows.Forms.PictureBox
        Private label16 As Windows.Forms.Label
        Private pictureBox17 As Windows.Forms.PictureBox
        Private label17 As Windows.Forms.Label
        Private pictureBox1 As Windows.Forms.PictureBox
        Private lblAppID As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
        Private label1 As Windows.Forms.Label
        Private lblStutesDate As Windows.Forms.Label
        Private pictureBox2 As Windows.Forms.PictureBox
        Private label5 As Windows.Forms.Label
    End Class
End Namespace
