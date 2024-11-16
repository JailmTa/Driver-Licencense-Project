Imports System
Imports System.Data
Imports System.Windows.Forms
Imports BussnessLayerForDVLD


Namespace DVLD_Project
    Public Partial Class Form2
        Inherits Form
        Public Sub New()
            InitializeComponent()

        End Sub

        Private Sub guna2Button1_Click(sender As Object, e As EventArgs)
            Dim form3 As Form3 = New Form3()
            form3.ShowDialog()
        End Sub

        Private Sub Form2_Load(sender As Object, e As EventArgs)
            guna2DataGridView1.DataSource = clsBussnesLayer.GettAllPersons()
            Dim dt As DataTable = clsBussnesLayer.GettAllPersons()
            cbFilters.Items.Add("None")
            cbFilters.SelectedIndex = 0
            For Each column As DataColumn In dt.Columns
                cbFilters.Items.Add(column.ColumnName)
            Next
        End Sub

        Private Sub editePersonToolStripMenuItem_Click(sender As Object, e As EventArgs)
            Dim form2 As Form3 = New Form3(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells(0).Value))
            form2.ShowDialog()
        End Sub

        Private Sub deleteToolStripMenuItem_Click(sender As Object, e As EventArgs)
            clsBussnesLayer.DeletePerson(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells(0).Value))
        End Sub

        Private Sub showInformationsToolStripMenuItem_Click(sender As Object, e As EventArgs)
            Dim form As Form4 = New Form4(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells(0).Value))
            form.ShowDialog()
        End Sub

        Private Sub guna2TextBox1_TextChanged(sender As Object, e As EventArgs)
            If Equals(cbFilters.Text, "PersonID") Then
                Dim Num = 0
                If Not Equals(guna2TextBox1.Text, "") Then
                    Integer.TryParse(guna2TextBox1.Text, Num)
                    If Num = 0 Then
                        guna2TextBox1.Text = ""
                    Else
                        guna2DataGridView1.DataSource = clsBussnesLayer.FindWithFilters(Num, "", "")
                    End If
                End If
            ElseIf Not Equals(cbFilters.Text, "None") Then
                guna2DataGridView1.DataSource = clsBussnesLayer.FindWithFilters(0, cbFilters.Text, guna2TextBox1.Text)
            ElseIf Equals(cbFilters.Text, "None") OrElse Equals(guna2TextBox1.Text, "") Then
                guna2DataGridView1.DataSource = clsBussnesLayer.GettAllPersons()
            End If
        End Sub

        Private Sub cbFilters_SelectedIndexChanged(sender As Object, e As EventArgs)
            If Equals(cbFilters.Text, "None") Then
                guna2TextBox1.Visible = False
                guna2DataGridView1.DataSource = clsBussnesLayer.GettAllPersons()
            Else
                guna2TextBox1.Visible = True
                guna2DataGridView1.DataSource = clsBussnesLayer.GettAllPersons()
                guna2TextBox1.Clear()
            End If
        End Sub
    End Class
End Namespace
