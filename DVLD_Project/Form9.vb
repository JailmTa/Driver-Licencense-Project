Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Windows.Forms
Imports BussnessLayerForDVLD

Namespace DVLD_Project
    Public Partial Class Form9
        Inherits Form
        Private _ID As Integer = 0
        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(ID As Integer)
            InitializeComponent()
            _ID = ID
        End Sub

        Private Sub Form9_Load(sender As Object, e As EventArgs)
            Dim dt As DataTable = clsBussnesLayer.FindUser(clsBussnesLayer.GetUserID())
            If dt IsNot Nothing Then
                For Each dr As DataRow In dt.Rows
                    lblUserID.Text = dr("UserID").ToString()
                    tbUserName.Text = dr("UserName").ToString()
                    Exit For
                Next
            End If
        End Sub

        Private Sub guna2Button1_Click(sender As Object, e As EventArgs)
            If Equals(tbPassWord.Text, tbConPassWord.Text) Then
                If _ID = 0 Then
                    Dim _UserID As Integer = clsBussnesLayer.GetUserID(), _PersonID = 0
                    Dim dataTable = clsBussnesLayer.FindUser(_UserID)
                    If dataTable IsNot Nothing Then
                        For Each dr As DataRow In dataTable.Rows
                            _PersonID = Convert.ToInt32(dr("PersonID"))
                        Next
                    End If
                    Dim PassWord = ""
                    For Each c In tbPassWord.Text
                        PassWord += Microsoft.VisualBasic.ChrW(Microsoft.VisualBasic.AscW(c) + 15)
                    Next
                    clsBussnesLayer.UpdateUser(_UserID, _PersonID, tbUserName.Text, PassWord, ckbActive.Checked)
                Else
                    Dim _PersonID = 0
                    Dim dataTable = clsBussnesLayer.FindUser(_ID)
                    If dataTable IsNot Nothing Then
                        For Each dr As DataRow In dataTable.Rows
                            _PersonID = Convert.ToInt32(dr("PersonID"))
                        Next
                    End If
                    Dim PassWord = ""
                    For Each c In tbPassWord.Text
                        PassWord += Microsoft.VisualBasic.ChrW(Microsoft.VisualBasic.AscW(c) + 15)
                    Next
                    clsBussnesLayer.UpdateUser(_ID, _PersonID, tbUserName.Text, PassWord, ckbActive.Checked)
                End If
            Else
                MessageBox.Show("The PassWord Not Matched ", "Error At UpDate", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Sub

        Private Sub tbOldPassWord_Validating(sender As Object, e As CancelEventArgs)
            If _ID = 0 Then
                _ID = clsBussnesLayer.GetUserID()
            End If
            Dim PassWord = ""
            For Each c In tbOldPassWord.Text
                PassWord += Microsoft.VisualBasic.ChrW(Microsoft.VisualBasic.AscW(c) + 15)
            Next
            If clsBussnesLayer.LoginUser(tbUserName.Text, PassWord) > 0 Then
                e.Cancel = False
                errorProvider1.SetError(tbOldPassWord, "")
            Else
                e.Cancel = True
                tbOldPassWord.Focus()
                errorProvider1.SetError(tbOldPassWord, "This PassWord Is False !..")
            End If
        End Sub

        Private Sub tbOldPassWord_TextChanged(sender As Object, e As EventArgs)

        End Sub

        Private Sub label5_Click(sender As Object, e As EventArgs)

        End Sub
    End Class
End Namespace
