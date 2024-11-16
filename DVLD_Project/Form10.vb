Imports BussnessLayerForDVLD
Imports System
Imports System.Windows.Forms

Namespace DVLD_Project
    Public Partial Class Form10
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form10_Load(sender As Object, e As EventArgs)
            guna2DataGridView1.DataSource = clsBussnesLayer.GetAllAppTypes()
        End Sub

        Private Sub upDateToolStripMenuItem_Click(sender As Object, e As EventArgs)
            Dim form11 As Form11 = New Form11(Convert.ToInt16(guna2DataGridView1.CurrentRow.Cells(0).Value), guna2DataGridView1.CurrentRow.Cells(1).Value.ToString(), Convert.ToDouble(guna2DataGridView1.CurrentRow.Cells(2).Value))
            form11.Show()
        End Sub
    End Class
End Namespace
