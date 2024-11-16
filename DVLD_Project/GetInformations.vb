Imports System
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports BussnessLayerForDVLD

Namespace DVLD_Project
    Public Partial Class GetInformations
        Inherits UserControl
        Private _ID As Integer = 0
        Private _NetionalNo As String = ""
        Public Sub New(ID As Integer)
            InitializeComponent()
            _ID = ID

        End Sub

        Public Sub New()
            InitializeComponent()

        End Sub

        Private Sub groupBox1_Enter(sender As Object, e As EventArgs)

        End Sub

        Private Sub GetInformations_Load(sender As Object, e As EventArgs)
            Dim dt = clsBussnesLayer.Find(_ID)
            If dt IsNot Nothing Then

                For Each dr As DataRow In dt.Rows
                    lblPersonID.Text = dr(0).ToString()
                    _ID = Convert.ToInt32(dr(0).ToString())
                    lblNationalID.Text = dr(1).ToString()
                    _NetionalNo = dr(1).ToString()
                    lblName.Text = dr(2).ToString() & dr(3).ToString() & dr(4).ToString() & dr(5).ToString()
                    lblBirthDate.Text = dr(6).ToString()
                    lblGonder.Text = dr(7).ToString()
                    lblAddreass.Text = dr(8).ToString()
                    lblPhone.Text = dr(9).ToString()
                    lblEmail.Text = dr(10).ToString()
                    lblCountry.Text = dr(11).ToString()
                    If dr(12) IsNot Nothing Then pbProfile.Image = Image.FromFile(dr(12).ToString())
                Next
            End If
        End Sub

        Public Function GetID() As Integer
            Return _ID
        End Function
        Public Function GetNetionalNo() As String
            Return _NetionalNo
        End Function

        Public Sub GetInfo(Num As Integer)
            Dim dt = clsBussnesLayer.Find(Num)
            If dt IsNot Nothing Then
                _ID = Num
                For Each dr As DataRow In dt.Rows
                    lblPersonID.Text = dr(0).ToString()
                    lblNationalID.Text = dr(1).ToString()
                    _NetionalNo = dr(1).ToString()
                    lblName.Text = dr(2).ToString() & dr(3).ToString() & dr(4).ToString() & dr(5).ToString()
                    lblBirthDate.Text = dr(6).ToString()
                    lblGonder.Text = dr(7).ToString()
                    lblAddreass.Text = dr(8).ToString()
                    lblPhone.Text = dr(9).ToString()
                    lblEmail.Text = dr(10).ToString()
                    lblCountry.Text = dr(11).ToString()
                    If dr(12) IsNot Nothing Then pbProfile.Image = Image.FromFile(dr(12).ToString())
                Next
            End If
        End Sub

        Public Sub GetInfoNetionalNo(Num As String)
            Dim dt = clsBussnesLayer.FindWithFilters(0, "NationalNo", Num)
            If dt IsNot Nothing Then

                For Each dr As DataRow In dt.Rows
                    lblPersonID.Text = dr(0).ToString()
                    _ID = Convert.ToInt32(dr(0).ToString())
                    lblNationalID.Text = dr(1).ToString()
                    _NetionalNo = dr(1).ToString()
                    lblName.Text = dr(2).ToString() & dr(3).ToString() & dr(4).ToString() & dr(5).ToString()
                    lblBirthDate.Text = dr(6).ToString()
                    lblGonder.Text = dr(7).ToString()
                    lblAddreass.Text = dr(8).ToString()
                    lblPhone.Text = dr(9).ToString()
                    lblEmail.Text = dr(10).ToString()
                    lblCountry.Text = dr(11).ToString()
                    If dr(12) IsNot Nothing Then pbProfile.Image = Image.FromFile(dr(12).ToString())
                Next
            End If
        End Sub


        Private Sub linkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
            Dim form3 As Form3 = New Form3(_ID)
            form3.ShowDialog()
        End Sub
    End Class
End Namespace
