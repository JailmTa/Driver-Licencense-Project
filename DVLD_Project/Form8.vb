Imports System
Imports System.Windows.Forms

Namespace DVLD_Project
    Public Partial Class Form8
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub getInformations1_Load(sender As Object, e As EventArgs)

        End Sub

        Private Sub Form8_Load(sender As Object, e As EventArgs)
            getInformations1.GetInfo(userInfo1.getPersonID())
        End Sub
    End Class
End Namespace
