Imports System
Imports System.Windows.Forms

Namespace DVLD_Project
    Public Partial Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub peopleToolStripMenuItem_Click(sender As Object, e As EventArgs)
            Dim form2 As Form2 = New Form2()
            form2.ShowDialog()
        End Sub

        Private Sub usersToolStripMenuItem_Click(sender As Object, e As EventArgs)
            Dim form2 As Form6 = New Form6()
            form2.ShowDialog()
        End Sub

        Private Sub settingsToolStripMenuItem_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub showUserInformationsToolStripMenuItem_Click(sender As Object, e As EventArgs)
            Dim form8 As Form8 = New Form8()
            form8.ShowDialog()
        End Sub

        Private Sub logoutToolStripMenuItem_Click(sender As Object, e As EventArgs)
            Hide()
            Dim form5 As Form5 = New Form5()
            form5.ShowDialog()
        End Sub

        Private Sub changePassWordToolStripMenuItem_Click(sender As Object, e As EventArgs)
            Dim form9 As Form9 = New Form9()
            form9.ShowDialog()
        End Sub

        Private Sub maneageApplicationTypesToolStripMenuItem_Click(sender As Object, e As EventArgs)
            Dim form10 As Form10 = New Form10()
            form10.ShowDialog()
        End Sub

        Private Sub maneageTestsTypesToolStripMenuItem_Click(sender As Object, e As EventArgs)
            Dim form12 As Form12 = New Form12()
            form12.ShowDialog()
        End Sub

        Private Sub newLocaleLicenseToolStripMenuItem_Click(sender As Object, e As EventArgs)
            Dim form15 As Form15 = New Form15()
            form15.ShowDialog()
        End Sub

        Private Sub maneageApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs)
            Dim form14 As Form14 = New Form14()
            form14.ShowDialog()
        End Sub

        Private Sub drivingLicenseServerToolStripMenuItem_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub driversToolStripMenuItem_Click(sender As Object, e As EventArgs)
            Dim form18 As Form18 = New Form18()
            form18.ShowDialog()
        End Sub
    End Class
End Namespace
