Imports BussnessLayerForDVLD
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DVLD_Project.Properties
Imports System.IO


Namespace DVLD_Project
    Public Partial Class AddPerson
        Inherits UserControl
        Private _ID As Integer = 0
        Private _ImagePath As String = "", _DS As String = ""
        Public Sub New(Title As String)
            InitializeComponent()
            Dim dt As DataTable = clsBussnesLayer.GetAllCountraies()
            For Each row As DataRow In dt.Rows
                cbCountry.Items.Add(row(1))
            Next
            rbMale.Checked = True
            dtpBirthDate.MaxDate = New DateTime(Date.Now.Year - 18, Date.Now.Month, Date.Now.Day)
            pbProfile.Image = Resources.icons8_male_64
        End Sub

        Public Sub New(Title As String, ID As Integer)
            InitializeComponent()
            Dim dt1 As DataTable = clsBussnesLayer.GetAllCountraies()
            For Each row As DataRow In dt1.Rows
                cbCountry.Items.Add(row(1))
            Next
            _ID = ID
            Dim dt = clsBussnesLayer.Find(ID)
            If dt IsNot Nothing Then
                For Each dr As DataRow In dt.Rows
                    lblPersonID.Text = dr(0).ToString()
                    tbNationalID.Text = dr(1).ToString()
                    tbFirstName.Text = dr(2).ToString()
                    tbSecondName.Text = dr(3).ToString()
                    tbThirdName.Text = dr(4).ToString()
                    tbLastName.Text = dr(5).ToString()
                    dtpBirthDate.Value = Convert.ToDateTime(dr(6).ToString())
                    Dim c As Char = dr(7).ToString()(0)
                    If c = "M"c Then
                        rbMale.Checked = True
                    Else
                        rbFemal.Checked = True
                    End If
                    tbAddreass.Text = dr(8).ToString()
                    tbPhone.Text = dr(9).ToString()
                    tbEmail.Text = dr(10).ToString()
                    cbCountry.SelectedIndex = Convert.ToInt32(dr(11).ToString()) - 1
                    If Not Equals(dr(12).ToString(), "") Then pbProfile.Image = Image.FromFile(dr(12).ToString())
                    _DS = dr(12).ToString()
                Next
            End If
        End Sub

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub rbMale_CheckedChanged(sender As Object, e As EventArgs)
            pbProfile.Image = Resources.icons8_male_64
        End Sub

        Private Sub rbFemal_CheckedChanged(sender As Object, e As EventArgs)
            pbProfile.Image = Resources.icons8_female_64
        End Sub

        Private Sub tbEmail_TextChanged(sender As Object, e As EventArgs)

        End Sub

        Private Sub tbEmail_Validating(sender As Object, e As CancelEventArgs)
            If tbEmail.Text.Contains("@"c) AndAlso tbEmail.Text.Contains(".com") Then
                e.Cancel = False
                errorProvider1.SetError(tbEmail, "")
            Else
                e.Cancel = True
                tbEmail.Focus()
                errorProvider1.SetError(tbEmail, "This Email Is Not Suppurted")
            End If
        End Sub

        Private Sub linkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
            If rbMale.Checked Then
                pbProfile.Image = Resources.icons8_male_64
            Else
                pbProfile.Image = Resources.icons8_female_64
            End If
        End Sub

        Private Sub linkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
            openFileDialog1.ShowDialog(Me)
            _ImagePath = openFileDialog1.FileName
            Dim MainFolder = "c:/DVLD_Project"
            Dim Ds = Path.Combine(MainFolder, Path.GetFileName(_ImagePath))
            _DS = Ds
            Try
                File.Copy(_ImagePath, Ds, True)
                pbProfile.Image = Image.FromFile(Ds)
            Catch io As IOException

            End Try
        End Sub

        Private Sub guna2Button1_Click(sender As Object, e As EventArgs)
            Dim _Gender = " "c
            If rbFemal.Checked Then
                _Gender = "F"c
            Else
                _Gender = "M"c
            End If
            If _ID = 0 Then
                _ID = clsBussnesLayer.AddPerson(0, tbNationalID.Text, tbFirstName.Text, tbSecondName.Text, tbThirdName.Text, tbLastName.Text, dtpBirthDate.Value, _Gender, tbAddreass.Text, tbPhone.Text, tbEmail.Text, cbCountry.SelectedIndex + 1, _DS)
                lblPersonID.Text = _ID.ToString()
            Else
                clsBussnesLayer.UpDatePerson(_ID, tbNationalID.Text, tbFirstName.Text, tbSecondName.Text, tbThirdName.Text, tbLastName.Text, dtpBirthDate.Value, _Gender, tbAddreass.Text, tbPhone.Text, tbEmail.Text, cbCountry.SelectedIndex + 1, _DS)
            End If
        End Sub

        Private Sub AddPerson_Load(sender As Object, e As EventArgs)

        End Sub

        Public Function getID() As Integer
            Return _ID
        End Function
    End Class
End Namespace
