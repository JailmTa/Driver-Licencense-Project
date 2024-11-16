Imports BussnessLayerForDVLD
Imports System
Imports System.Data
Imports System.Windows.Forms

Namespace DVLD_Project
    Public Partial Class Form15
        Inherits Form
        Private _ID As Integer = 0
        Public Sub New()
            InitializeComponent()
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

        Private Sub Form15_Load(sender As Object, e As EventArgs)
            Dim dt As DataTable = clsBussnesLayer.GettAllPersons()
            For Each column As DataColumn In dt.Columns
                cbFilters.Items.Add(column.ColumnName)
            Next
            dt.Clear()
            dt = clsBussnesLayer.GetAllClassesName()
            For Each column As DataRow In dt.Rows
                cbClassesName.Items.Add(column(1))
            Next
            lblDate.Text = Date.Now.ToString()
            lblFees.Text = "20"
            dt.Clear()
            dt = clsBussnesLayer.FindUser(clsBussnesLayer.GetUserID())
            If dt IsNot Nothing Then
                For Each dr As DataRow In dt.Rows
                    lblCreateBy.Text = dr("UserName").ToString()

                Next
            End If
        End Sub

        Private Sub tabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs)
            Dim flag = clsBussnesLayer.FindWithFiltersL(_ID, "PersonID", "") IsNot Nothing
            If flag Then
                e.Cancel = flag
                MessageBox.Show("888")
            Else

            End If
        End Sub

        Private Sub tabPage2_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub guna2Button1_Click(sender As Object, e As EventArgs)
            If clsBussnesLayer.CheckForAddLecines(getInformations1.GetNetionalNo(), cbClassesName.Text) Then
                Dim _AppID As Integer = clsBussnesLayer.AddApp(0, getInformations1.GetID(), Date.Now, 1, 1, Date.Now, 20F, clsBussnesLayer.GetUserID())
                lblAppID.Text = _AppID.ToString()
                '  int _TestA = clsBussnesLayer.AddTestA(0, 1, _D, DateTime.Now, 20f, clsBussnesLayer.GetUserID(), true);
                '  clsBussnesLayer.AddTest(0, _TestA, true, ".", clsBussnesLayer.GetUserID());
                Dim _D = clsBussnesLayer.AddDrivingL(0, _AppID, cbClassesName.SelectedIndex + 1)
            Else
                MessageBox.Show("8888")
            End If
        End Sub


    End Class
End Namespace
