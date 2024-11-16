Imports System
Imports System.Windows.Forms
Imports BussnessLayerForDVLD

Namespace DVLD_Project
    Public Partial Class Form18
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form18_Load(sender As Object, e As EventArgs)
            guna2DataGridView1.DataSource = clsBussnesLayer.GetAllDrvers()
        End Sub
    End Class
End Namespace
