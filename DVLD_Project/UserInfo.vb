Imports BussnessLayerForDVLD
Imports System
Imports System.Data
Imports System.Windows.Forms

Namespace DVLD_Project
    Public Partial Class UserInfo
        Inherits UserControl
        Private _UserID As Integer = 0, _PersonID As Integer = 0
        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(userID As Integer)
            InitializeComponent()
            _UserID = userID
            Dim dt = clsBussnesLayer.FindUser(_UserID)
            If dt IsNot Nothing Then
                For Each dr As DataRow In dt.Rows
                    lblUesrName.Text = dr("UserName").ToString()
                    lblUserID.Text = dr("UserID").ToString()
                    lblActive.Text = dr("IsActive").ToString()
                    _PersonID = Convert.ToInt32(dr("PersonID"))
                Next
            End If
        End Sub

        Private Sub UserInfo_Load(sender As Object, e As EventArgs)

        End Sub

        Private Sub groupBox1_Enter(sender As Object, e As EventArgs)

        End Sub

        Private Sub linkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
            Dim form As Form9 = New Form9(_UserID)
            form.ShowDialog()
        End Sub

        Public Function getPersonID() As Integer
            Return _PersonID
        End Function

    End Class
End Namespace
