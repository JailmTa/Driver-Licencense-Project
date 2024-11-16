Imports BussnessLayerForDVLD
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Windows.Forms

Namespace DVLD_Project

    Public Partial Class Form7
        Inherits Form
        Private _Flag As Boolean = False
        Private _ID As Integer = 0, _UsserID As Integer = 0
        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(ID As Integer, PersonID As Integer)
            InitializeComponent()
            _ID = ID
            cbFilters.Enabled = False
            guna2TextBox1.Enabled = False
            guna2Button3.Enabled = False
            guna2Button4.Enabled = False
            getInformations1.GetInfo(ID)
            _UsserID = PersonID
        End Sub

        Private Sub Form7_Load(sender As Object, e As EventArgs)
            Dim dt As DataTable = clsBussnesLayer.GettAllPersons()
            For Each column As DataColumn In dt.Columns
                cbFilters.Items.Add(column.ColumnName)
            Next
        End Sub

        Private Function Encryption() As String
            Dim Text = ""
            For Each c In tbPassWord.Text
                Text += Microsoft.VisualBasic.ChrW(Microsoft.VisualBasic.AscW(c) + 15)
            Next
            Return Text
        End Function

        Private Sub guna2Button1_Click(sender As Object, e As EventArgs)
            If cbFilters.Enabled Then
                clsBussnesLayer.AddUsers(0, _ID, tbUserName.Text, Encryption(), ckbActive.Checked)
            ElseIf Equals(tbConPassWord.Text, tbPassWord.Text) Then
                clsBussnesLayer.UpdateUser(_UsserID, _ID, tbUserName.Text, Encryption(), ckbActive.Checked)
            Else
                MessageBox.Show("The PassWord Not Matched ", "Error At UpDate", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Sub

        Private Sub guna2Button3_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub getInformations1_Load(sender As Object, e As EventArgs)

        End Sub

        Private Sub button1_Click(sender As Object, e As EventArgs)
            tabControl1.SelectedIndex = 1
        End Sub

        Private Sub filterPeople1_Load(sender As Object, e As EventArgs)

        End Sub

        Private Sub cbFilters_SelectedIndexChanged(sender As Object, e As EventArgs)

        End Sub

        Private Sub guna2TextBox1_TextChanged(sender As Object, e As EventArgs)
            Dim dt As DataTable = New DataTable()
            If Equals(cbFilters.Text, "PersonID") Then
                Dim Num = 0
                If Not Equals(guna2TextBox1.Text, "") Then
                    Integer.TryParse(guna2TextBox1.Text, Num)
                    If Num = 0 Then
                        guna2TextBox1.Text = ""
                    Else
                        dt = clsBussnesLayer.FindWithFilters(Num, "", "")
                        If dt IsNot Nothing Then
                            For Each row As DataRow In dt.Rows
                                _ID = Convert.ToInt32(row(0))
                                Exit For
                            Next
                        End If

                    End If
                End If
            Else
                dt = clsBussnesLayer.FindWithFilters(0, cbFilters.Text, guna2TextBox1.Text)
                If dt IsNot Nothing Then
                    For Each row As DataRow In dt.Rows
                        _ID = Convert.ToInt32(row(0))
                        Exit For
                    Next
                End If
            End If

            getInformations1.GetInfo(_ID)
        End Sub

        Private Sub tabPage1_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub guna2Button5_Click(sender As Object, e As EventArgs)
            If clsBussnesLayer.FindWithFiltersU(_ID, "PersonID", "") IsNot Nothing AndAlso Not guna2TextBox1.Enabled Then
                tabControl1.SelectedIndex = 1
                Dim dt = clsBussnesLayer.FindUser(_UsserID)
                If dt IsNot Nothing Then
                    For Each dr As DataRow In dt.Rows
                        lblUserID.Text = dr("UserID").ToString()
                        tbUserName.Text = dr("UserName").ToString()
                        Exit For
                    Next
                End If
            Else
                MessageBox.Show("888")
            End If
        End Sub

        Private Sub tabPage2_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub tbOldPassWord_Validating(sender As Object, e As CancelEventArgs)
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

        Private Sub tabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs)
            Dim flag = clsBussnesLayer.FindWithFiltersU(_ID, "PersonID", "") IsNot Nothing AndAlso guna2TextBox1.Enabled
            If flag Then
                e.Cancel = flag
                MessageBox.Show("888")
            Else

            End If
        End Sub
    End Class
End Namespace
