Imports System
Imports System.Data
Imports System.Windows.Forms
Imports BussnessLayerForDVLD

Namespace DVLD_Project
    Public Partial Class Form5
        Inherits Form
        Public Sub New()
            InitializeComponent()

        End Sub

        Private Sub guna2Button1_Click(sender As Object, e As EventArgs)
            Dim txt = ""
            For Each c In tbPassWord.Text.ToString()
                txt += Microsoft.VisualBasic.ChrW(Microsoft.VisualBasic.AscW(c) + 15)
            Next
            Dim Num = clsBussnesLayer.LoginUser(tbUserName.Text, txt)
            clsBussnesLayer.SetLogin(Num)
            If Num > 0 Then
                If checkBox1.Checked Then
                    clsBussnesLayer.UpdateUserCopy(0, 0, tbUserName.Text, tbPassWord.Text, True)
                Else
                    clsBussnesLayer.UpdateUserCopy(0, 0, "", "", True)
                End If
                Hide()
                Dim form As Form1 = New Form1()
                form.ShowDialog()
            Else
                MessageBox.Show("nnnn")
            End If

        End Sub

        Private Sub checkBox1_CheckedChanged(sender As Object, e As EventArgs)

        End Sub

        Private Sub Form5_Load(sender As Object, e As EventArgs)
            Dim dt As DataTable = clsBussnesLayer.FindUserCop()
            For Each dr As DataRow In dt.Rows
                tbUserName.Text = dr("UserName").ToString()
                tbPassWord.Text = dr("PassWord").ToString()
                checkBox1.Checked = True
                Exit For
            Next
        End Sub
    End Class
End Namespace
