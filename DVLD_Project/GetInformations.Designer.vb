Namespace DVLD_Project
    Partial Class GetInformations
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
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(GetInformations))
            label1 = New Windows.Forms.Label()
            groupBox1 = New Windows.Forms.GroupBox()
            lblBirthDate = New Windows.Forms.Label()
            lblAddreass = New Windows.Forms.Label()
            lblEmail = New Windows.Forms.Label()
            lblGonder = New Windows.Forms.Label()
            lblNationalID = New Windows.Forms.Label()
            lblName = New Windows.Forms.Label()
            lblCountry = New Windows.Forms.Label()
            lblPhone = New Windows.Forms.Label()
            label3 = New Windows.Forms.Label()
            label12 = New Windows.Forms.Label()
            label13 = New Windows.Forms.Label()
            label14 = New Windows.Forms.Label()
            label15 = New Windows.Forms.Label()
            label16 = New Windows.Forms.Label()
            label17 = New Windows.Forms.Label()
            label18 = New Windows.Forms.Label()
            lblPersonID = New Windows.Forms.Label()
            label2 = New Windows.Forms.Label()
            pbProfile = New Windows.Forms.PictureBox()
            pictureBox11 = New Windows.Forms.PictureBox()
            pictureBox12 = New Windows.Forms.PictureBox()
            pictureBox13 = New Windows.Forms.PictureBox()
            pictureBox14 = New Windows.Forms.PictureBox()
            pictureBox15 = New Windows.Forms.PictureBox()
            pictureBox16 = New Windows.Forms.PictureBox()
            pictureBox17 = New Windows.Forms.PictureBox()
            pictureBox18 = New Windows.Forms.PictureBox()
            pictureBox1 = New Windows.Forms.PictureBox()
            linkLabel1 = New Windows.Forms.LinkLabel()
            groupBox1.SuspendLayout()
            CType(pbProfile, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox11, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox12, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox13, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox14, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox15, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox16, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox17, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox18, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Font = New Drawing.Font("Microsoft Sans Serif", 18F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label1.ForeColor = Drawing.Color.FromArgb(255, 128, 128)
            label1.Location = New Drawing.Point(255, 16)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(208, 36)
            label1.TabIndex = 3
            label1.Text = "Person Details"
            ' 
            ' groupBox1
            ' 
            groupBox1.Controls.Add(linkLabel1)
            groupBox1.Controls.Add(lblBirthDate)
            groupBox1.Controls.Add(lblAddreass)
            groupBox1.Controls.Add(lblEmail)
            groupBox1.Controls.Add(lblGonder)
            groupBox1.Controls.Add(lblNationalID)
            groupBox1.Controls.Add(lblName)
            groupBox1.Controls.Add(lblCountry)
            groupBox1.Controls.Add(lblPhone)
            groupBox1.Controls.Add(pbProfile)
            groupBox1.Controls.Add(pictureBox11)
            groupBox1.Controls.Add(label3)
            groupBox1.Controls.Add(pictureBox12)
            groupBox1.Controls.Add(label12)
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
            groupBox1.Controls.Add(pictureBox18)
            groupBox1.Controls.Add(label18)
            groupBox1.Controls.Add(pictureBox1)
            groupBox1.Controls.Add(lblPersonID)
            groupBox1.Controls.Add(label2)
            groupBox1.Location = New Drawing.Point(3, 73)
            groupBox1.Name = "groupBox1"
            groupBox1.Size = New Drawing.Size(728, 295)
            groupBox1.TabIndex = 4
            groupBox1.TabStop = False
            groupBox1.Text = "Person Details"
            AddHandler groupBox1.Enter, New EventHandler(AddressOf groupBox1_Enter)
            ' 
            ' lblBirthDate
            ' 
            lblBirthDate.AutoSize = True
            lblBirthDate.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblBirthDate.Location = New Drawing.Point(365, 117)
            lblBirthDate.Name = "lblBirthDate"
            lblBirthDate.Size = New Drawing.Size(30, 16)
            lblBirthDate.TabIndex = 58
            lblBirthDate.Text = "N/A"
            ' 
            ' lblAddreass
            ' 
            lblAddreass.AutoSize = True
            lblAddreass.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblAddreass.Location = New Drawing.Point(121, 249)
            lblAddreass.Name = "lblAddreass"
            lblAddreass.Size = New Drawing.Size(30, 16)
            lblAddreass.TabIndex = 57
            lblAddreass.Text = "N/A"
            ' 
            ' lblEmail
            ' 
            lblEmail.AutoSize = True
            lblEmail.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblEmail.Location = New Drawing.Point(121, 205)
            lblEmail.Name = "lblEmail"
            lblEmail.Size = New Drawing.Size(30, 16)
            lblEmail.TabIndex = 56
            lblEmail.Text = "N/A"
            ' 
            ' lblGonder
            ' 
            lblGonder.AutoSize = True
            lblGonder.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblGonder.Location = New Drawing.Point(121, 161)
            lblGonder.Name = "lblGonder"
            lblGonder.Size = New Drawing.Size(30, 16)
            lblGonder.TabIndex = 55
            lblGonder.Text = "N/A"
            ' 
            ' lblNationalID
            ' 
            lblNationalID.AutoSize = True
            lblNationalID.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblNationalID.Location = New Drawing.Point(121, 117)
            lblNationalID.Name = "lblNationalID"
            lblNationalID.Size = New Drawing.Size(30, 16)
            lblNationalID.TabIndex = 54
            lblNationalID.Text = "N/A"
            ' 
            ' lblName
            ' 
            lblName.AutoSize = True
            lblName.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblName.Location = New Drawing.Point(121, 73)
            lblName.Name = "lblName"
            lblName.Size = New Drawing.Size(30, 16)
            lblName.TabIndex = 53
            lblName.Text = "N/A"
            ' 
            ' lblCountry
            ' 
            lblCountry.AutoSize = True
            lblCountry.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblCountry.Location = New Drawing.Point(365, 205)
            lblCountry.Name = "lblCountry"
            lblCountry.Size = New Drawing.Size(30, 16)
            lblCountry.TabIndex = 52
            lblCountry.Text = "N/A"
            ' 
            ' lblPhone
            ' 
            lblPhone.AutoSize = True
            lblPhone.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblPhone.Location = New Drawing.Point(365, 161)
            lblPhone.Name = "lblPhone"
            lblPhone.Size = New Drawing.Size(30, 16)
            lblPhone.TabIndex = 51
            lblPhone.Text = "N/A"
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label3.Location = New Drawing.Point(19, 249)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(66, 16)
            label3.TabIndex = 48
            label3.Text = "Addreass"
            ' 
            ' label12
            ' 
            label12.AutoSize = True
            label12.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label12.Location = New Drawing.Point(263, 205)
            label12.Name = "label12"
            label12.Size = New Drawing.Size(52, 16)
            label12.TabIndex = 46
            label12.Text = "Country"
            ' 
            ' label13
            ' 
            label13.AutoSize = True
            label13.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label13.Location = New Drawing.Point(263, 117)
            label13.Name = "label13"
            label13.Size = New Drawing.Size(62, 16)
            label13.TabIndex = 44
            label13.Text = "BirthDate"
            ' 
            ' label14
            ' 
            label14.AutoSize = True
            label14.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label14.Location = New Drawing.Point(263, 161)
            label14.Name = "label14"
            label14.Size = New Drawing.Size(46, 16)
            label14.TabIndex = 42
            label14.Text = "Phone"
            ' 
            ' label15
            ' 
            label15.AutoSize = True
            label15.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label15.Location = New Drawing.Point(19, 205)
            label15.Name = "label15"
            label15.Size = New Drawing.Size(41, 16)
            label15.TabIndex = 40
            label15.Text = "Email"
            ' 
            ' label16
            ' 
            label16.AutoSize = True
            label16.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label16.Location = New Drawing.Point(19, 161)
            label16.Name = "label16"
            label16.Size = New Drawing.Size(52, 16)
            label16.TabIndex = 38
            label16.Text = "Gonder"
            ' 
            ' label17
            ' 
            label17.AutoSize = True
            label17.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label17.Location = New Drawing.Point(19, 117)
            label17.Name = "label17"
            label17.Size = New Drawing.Size(70, 16)
            label17.TabIndex = 36
            label17.Text = "NationalID"
            ' 
            ' label18
            ' 
            label18.AutoSize = True
            label18.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label18.Location = New Drawing.Point(19, 73)
            label18.Name = "label18"
            label18.Size = New Drawing.Size(44, 16)
            label18.TabIndex = 34
            label18.Text = "Name"
            ' 
            ' lblPersonID
            ' 
            lblPersonID.AutoSize = True
            lblPersonID.ImageAlign = Drawing.ContentAlignment.MiddleRight
            lblPersonID.Location = New Drawing.Point(121, 29)
            lblPersonID.Name = "lblPersonID"
            lblPersonID.Size = New Drawing.Size(30, 16)
            lblPersonID.TabIndex = 12
            lblPersonID.Text = "N/A"
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.ImageAlign = Drawing.ContentAlignment.MiddleRight
            label2.Location = New Drawing.Point(19, 29)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(63, 16)
            label2.TabIndex = 10
            label2.Text = "PersonID"
            ' 
            ' pbProfile
            ' 
            pbProfile.Location = New Drawing.Point(548, 66)
            pbProfile.Name = "pbProfile"
            pbProfile.Size = New Drawing.Size(153, 173)
            pbProfile.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pbProfile.TabIndex = 50
            pbProfile.TabStop = False
            ' 
            ' pictureBox11
            ' 
            pictureBox11.Image = Global.DVLD_Project.Properties.Resources.icons8_shipping_location_64
            pictureBox11.Location = New Drawing.Point(82, 242)
            pictureBox11.Name = "pictureBox11"
            pictureBox11.Size = New Drawing.Size(33, 31)
            pictureBox11.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox11.TabIndex = 49
            pictureBox11.TabStop = False
            ' 
            ' pictureBox12
            ' 
            pictureBox12.Image = Global.DVLD_Project.Properties.Resources.icons8_worldwide_location_64
            pictureBox12.Location = New Drawing.Point(326, 198)
            pictureBox12.Name = "pictureBox12"
            pictureBox12.Size = New Drawing.Size(33, 31)
            pictureBox12.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox12.TabIndex = 47
            pictureBox12.TabStop = False
            ' 
            ' pictureBox13
            ' 
            pictureBox13.Image = Global.DVLD_Project.Properties.Resources.icons8_date_64
            pictureBox13.Location = New Drawing.Point(326, 110)
            pictureBox13.Name = "pictureBox13"
            pictureBox13.Size = New Drawing.Size(33, 31)
            pictureBox13.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox13.TabIndex = 45
            pictureBox13.TabStop = False
            ' 
            ' pictureBox14
            ' 
            pictureBox14.Image = Global.DVLD_Project.Properties.Resources.icons8_phone_64
            pictureBox14.Location = New Drawing.Point(326, 154)
            pictureBox14.Name = "pictureBox14"
            pictureBox14.Size = New Drawing.Size(33, 31)
            pictureBox14.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox14.TabIndex = 43
            pictureBox14.TabStop = False
            ' 
            ' pictureBox15
            ' 
            pictureBox15.Image = Global.DVLD_Project.Properties.Resources.icons8_email_64
            pictureBox15.Location = New Drawing.Point(82, 198)
            pictureBox15.Name = "pictureBox15"
            pictureBox15.Size = New Drawing.Size(33, 31)
            pictureBox15.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox15.TabIndex = 41
            pictureBox15.TabStop = False
            ' 
            ' pictureBox16
            ' 
            pictureBox16.Image = Global.DVLD_Project.Properties.Resources.icons8_male_64
            pictureBox16.Location = New Drawing.Point(82, 154)
            pictureBox16.Name = "pictureBox16"
            pictureBox16.Size = New Drawing.Size(33, 31)
            pictureBox16.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox16.TabIndex = 39
            pictureBox16.TabStop = False
            ' 
            ' pictureBox17
            ' 
            pictureBox17.Image = CType(resources.GetObject("pictureBox17.Image"), Drawing.Image)
            pictureBox17.Location = New Drawing.Point(82, 110)
            pictureBox17.Name = "pictureBox17"
            pictureBox17.Size = New Drawing.Size(33, 31)
            pictureBox17.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox17.TabIndex = 37
            pictureBox17.TabStop = False
            ' 
            ' pictureBox18
            ' 
            pictureBox18.Image = Global.DVLD_Project.Properties.Resources.icons8_person_64
            pictureBox18.Location = New Drawing.Point(82, 66)
            pictureBox18.Name = "pictureBox18"
            pictureBox18.Size = New Drawing.Size(33, 31)
            pictureBox18.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
            pictureBox18.TabIndex = 35
            pictureBox18.TabStop = False
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
            ' linkLabel1
            ' 
            linkLabel1.AutoSize = True
            linkLabel1.Location = New Drawing.Point(562, 37)
            linkLabel1.Name = "linkLabel1"
            linkLabel1.Size = New Drawing.Size(129, 16)
            linkLabel1.TabIndex = 59
            linkLabel1.TabStop = True
            linkLabel1.Text = "UpDate Informations"
            AddHandler linkLabel1.LinkClicked, New Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf linkLabel1_LinkClicked)
            ' 
            ' GetInformations
            ' 
            AutoScaleDimensions = New Drawing.SizeF(8F, 16F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            Controls.Add(groupBox1)
            Controls.Add(label1)
            Name = "GetInformations"
            Size = New Drawing.Size(739, 373)
            AddHandler Load, New EventHandler(AddressOf GetInformations_Load)
            groupBox1.ResumeLayout(False)
            groupBox1.PerformLayout()
            CType(pbProfile, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox11, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox12, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox13, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox14, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox15, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox16, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox17, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox18, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private label1 As Windows.Forms.Label
        Private groupBox1 As Windows.Forms.GroupBox
        Private pbProfile As Windows.Forms.PictureBox
        Private pictureBox11 As Windows.Forms.PictureBox
        Private label3 As Windows.Forms.Label
        Private pictureBox12 As Windows.Forms.PictureBox
        Private label12 As Windows.Forms.Label
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
        Private pictureBox18 As Windows.Forms.PictureBox
        Private label18 As Windows.Forms.Label
        Private pictureBox1 As Windows.Forms.PictureBox
        Private lblPersonID As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
        Private lblBirthDate As Windows.Forms.Label
        Private lblAddreass As Windows.Forms.Label
        Private lblEmail As Windows.Forms.Label
        Private lblGonder As Windows.Forms.Label
        Private lblNationalID As Windows.Forms.Label
        Private lblName As Windows.Forms.Label
        Private lblCountry As Windows.Forms.Label
        Private lblPhone As Windows.Forms.Label
        Private linkLabel1 As Windows.Forms.LinkLabel
    End Class
End Namespace
