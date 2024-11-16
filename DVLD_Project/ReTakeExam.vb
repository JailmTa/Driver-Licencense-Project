Imports System
Imports System.Windows.Forms

Namespace DVLD_Project
    Public Partial Class ReTakeExam
        Inherits UserControl
        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub LoadControl(NumberOfExamsBefor As Integer, ExamFees As Single)
            If NumberOfExamsBefor = 0 Then
                lblFeesR.Text = "0"
                lblFeesT.Text = ExamFees.ToString()
            Else
                lblFeesR.Text = "5"
                lblFeesT.Text = (5F + ExamFees).ToString()
            End If
        End Sub

        Public Function GetTotalFees() As Single
            Return Single.Parse(lblFeesT.Text.ToString())
        End Function

        Private Sub ReTakeExam_Load(sender As Object, e As EventArgs)

        End Sub
    End Class
End Namespace
