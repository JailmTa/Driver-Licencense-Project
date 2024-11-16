Imports System
Imports System.Data
Imports System.Windows.Forms
Imports BussnessLayerForDVLD

Namespace DVLD_Project
    Public Partial Class TestMainInformations
        Inherits UserControl
        Public Sub New()
            InitializeComponent()
        End Sub


        Public Sub LoadControal(Mode As String)
            If Equals(Mode, "Read") Then
                dateTimePicker1.Visible = False
                lblTestDate.Visible = True
            Else
                dateTimePicker1.Visible = True
                lblTestDate.Visible = False
            End If
        End Sub

        Public Sub LoadControal(Mode As String, ExamMode As Integer, DL As Integer, TestID As Integer, ClassID As Integer)
            Dim dt = clsBussnesLayer.GetInfoTest(DL, TestID, ClassID)
            If dt IsNot Nothing Then
                For Each dr As DataRow In dt.Rows

                    lblAppID.Text = dr("LocalDrivingLicenseApplicationID").ToString()
                    lblName.Text = dr("FullName").ToString()
                    lblType.Text = dr("ClassName").ToString()
                    lblFees.Text = "10"
                    lblTrye.Text = dr("Trayes").ToString()
                Next
            End If
            If Equals(Mode, "Read") Then
                dateTimePicker1.Visible = False
                lblTestDate.Visible = True
            Else
                dateTimePicker1.Visible = True
                lblTestDate.Visible = False
            End If

        End Sub

        Public Function GetTotalTryes() As Integer
            Return Convert.ToInt32(lblTrye.Text)
        End Function

        Private Sub TestMainInformations_Load(sender As Object, e As EventArgs)

        End Sub
        Public Function GetNewDateTime() As Date
            Return dateTimePicker1.Value
        End Function
    End Class
End Namespace
