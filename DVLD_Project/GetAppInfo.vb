Imports System
Imports System.Windows.Forms

Namespace DVLD_Project
    Public Partial Class GetAppInfo
        Inherits UserControl
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub label5_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub pictureBox1_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub lblTypeID_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub groupBox1_Enter(sender As Object, e As EventArgs)

        End Sub

        Public Sub LoadInformations(AppID As Integer, ClassName As String, NumOfExamsHasDone As Integer)

            lblAppID.Text = AppID.ToString()
            lblClassName.Text = ClassName.ToString()
            lblExamsDone.Text = NumOfExamsHasDone.ToString() & "/3 - Has Done !.."
            If NumOfExamsHasDone = 3 Then
                linkLabel1.Enabled = True
            Else
                linkLabel1.Enabled = False
            End If

        End Sub

        Private Sub GetAppInfo_Load(sender As Object, e As EventArgs)

        End Sub
    End Class
End Namespace
