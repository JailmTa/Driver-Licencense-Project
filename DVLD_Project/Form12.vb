Imports System
Imports System.Windows.Forms
Imports BussnessLayerForDVLD

Namespace DVLD_Project
    Public Partial Class Form12
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form12_Load(sender As Object, e As EventArgs)
            guna2DataGridView1.DataSource = clsBussnesLayer.GetAllTestTypes()
        End Sub

        Private Sub upDateToolStripMenuItem_Click(sender As Object, e As EventArgs)
            Dim form13 As Form13 = New Form13(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells(0).Value), guna2DataGridView1.CurrentRow.Cells(1).Value.ToString(), guna2DataGridView1.CurrentRow.Cells(2).Value.ToString(), Convert.ToDouble(guna2DataGridView1.CurrentRow.Cells(3).Value.ToString()))
            form13.ShowDialog()
        End Sub
    End Class
End Namespace
