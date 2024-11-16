Imports System
Imports System.Data
Imports System.Windows.Forms
Imports BussnessLayerForDVLD

Namespace DVLD_Project
    Public Partial Class Form6
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form6_Load(sender As Object, e As EventArgs)
            Dim dt As DataTable = clsBussnesLayer.GetAllUsersShowing()
            guna2DataGridView1.DataSource = dt
            cbFilters.Items.Add("None")
            guna2TextBox1.Visible = False
            cbIsActive.Visible = False
            cbFilters.SelectedIndex = 0
            For Each column As DataColumn In dt.Columns
                cbFilters.Items.Add(column.ColumnName)
            Next
        End Sub

        Private Sub guna2Button1_Click(sender As Object, e As EventArgs)
            Dim form7 As Form7 = New Form7()
            form7.ShowDialog()
        End Sub

        Private Sub cbFilters_SelectedIndexChanged(sender As Object, e As EventArgs)
            If Equals(cbFilters.Text, "None") Then
                guna2TextBox1.Visible = False
                cbIsActive.Visible = False
                guna2DataGridView1.DataSource = clsBussnesLayer.GetAllUsersShowing()
            ElseIf Not Equals(cbFilters.Text, "IsActive") Then
                guna2TextBox1.Visible = True
                guna2DataGridView1.DataSource = clsBussnesLayer.GetAllUsersShowing()
                guna2TextBox1.Clear()
                cbIsActive.Visible = False
            Else
                guna2TextBox1.Visible = False
                guna2DataGridView1.DataSource = clsBussnesLayer.GetAllUsersShowing()
                cbIsActive.Visible = True
            End If
        End Sub

        Private Sub guna2TextBox1_TextChanged(sender As Object, e As EventArgs)
            If Equals(cbFilters.Text, "None") OrElse Equals(cbFilters.Text, "") Then

                guna2DataGridView1.DataSource = clsBussnesLayer.GetAllUsersShowing()
            ElseIf Equals(cbFilters.Text, "PersonID") OrElse Equals(cbFilters.Text, "UserID") Then

                Dim Num = 0
                If Not Equals(guna2TextBox1.Text, "") Then
                    Integer.TryParse(guna2TextBox1.Text, Num)
                    If Num = 0 Then
                        guna2TextBox1.Text = ""
                    Else
                        guna2DataGridView1.DataSource = clsBussnesLayer.FindWithFiltersU(Num, cbFilters.Text, "")
                    End If
                End If
            Else
                guna2DataGridView1.DataSource = clsBussnesLayer.FindWithFiltersU(0, cbFilters.Text, guna2TextBox1.Text)
            End If
        End Sub

        Private Sub cbIsActive_SelectedIndexChanged(sender As Object, e As EventArgs)
            If Not Equals(cbIsActive.Text, "None") Then
                guna2DataGridView1.DataSource = clsBussnesLayer.FindWithFiltersU(0, cbIsActive.Text, "")
            Else
                guna2DataGridView1.DataSource = clsBussnesLayer.GetAllUsersShowing()
            End If
        End Sub

        Private Sub toolStripMenuItem4_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub toolStripMenuItem1_Click(sender As Object, e As EventArgs)
            Dim form9 As Form8 = New Form8()
            form9.ShowDialog()
        End Sub

        Private Sub toolStripMenuItem3_Click(sender As Object, e As EventArgs)
            If clsBussnesLayer.DeleteUser(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells(0).Value)) = 0 Then
                MessageBox.Show("YOY CANT")
            End If


        End Sub

        Private Sub changePassWordToolStripMenuItem_Click(sender As Object, e As EventArgs)
            Dim form9 As Form9 = New Form9(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells(0).Value))
            form9.ShowDialog()
        End Sub

        Private Sub toolStripMenuItem2_Click(sender As Object, e As EventArgs)
            Dim form7 As Form7 = New Form7(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells(1).Value), Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells(0).Value))
            form7.ShowDialog()
        End Sub
    End Class
End Namespace
