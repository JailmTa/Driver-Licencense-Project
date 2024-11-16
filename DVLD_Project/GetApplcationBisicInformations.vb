Imports System
Imports System.Data
Imports System.Windows.Forms
Imports BussnessLayerForDVLD

Namespace DVLD_Project
    Public Partial Class GetApplcationBisicInformations
        Inherits UserControl
        Private AppID As Integer = 0, _DL As Integer = 0
        Private _NetionalNo As String = ""

        Public Sub New()
            InitializeComponent()
        End Sub





        Private Sub GetApplcationBisicInformations_Load(sender As Object, e As EventArgs)

        End Sub

        Public Sub GetInfo(AppID As Integer)
            Me.AppID = AppID
            Dim dt = clsBussnesLayer.FindApplcations(AppID)
            If dt IsNot Nothing Then
                For Each row As DataRow In dt.Rows
                    _DL = Convert.ToInt32(row("LocalDrivingLicenseApplicationID").ToString())
                    lblAppID.Text = row("ApplicationID").ToString()
                    lblCreatedBy.Text = row("UserName").ToString()
                    lblDate.Text = row("ApplicationDate").ToString()
                    lblFees.Text = row("ApplicationFees").ToString()
                    lblName.Text = row("FirstName").ToString() & " " & row("SecondName").ToString() & " " & row("ThirdName").ToString() & " " & row("LastName").ToString()
                    lblStatues.Text = row("Stutes").ToString()
                    _NetionalNo = row("NationalNo").ToString()
                    lblStutesDate.Text = row("LastStatusDate").ToString()
                    lblType.Text = row("ApplicationTypeTitle").ToString()

                    Exit For
                Next
            End If
        End Sub

        Private Sub linkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
            Dim form3 As Form3 = New Form3(_NetionalNo)
            form3.ShowDialog()
        End Sub

        Public Function GetDL() As Integer
            Return _DL
        End Function
    End Class
End Namespace
