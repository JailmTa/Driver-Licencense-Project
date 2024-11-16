Imports System
Imports System.Windows.Forms
Imports BussnessLayerForDVLD

Namespace DVLD_Project
    Public Partial Class Form11
        Inherits Form
        Private _N As Integer = 0
        Private _T As String = ""
        Private _F As Double = 0.0F
        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(N As Integer, T As String, F As Double)
            InitializeComponent()
            lblTypeID.Text = N.ToString()
            tbTypeName.Text = T.ToString()
            tbFees.Text = F.ToString()
            _N = N
            _T = T
            _F = F
        End Sub

        Private Sub Form11_Load(sender As Object, e As EventArgs)

        End Sub

        Private Sub label4_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub pictureBox2_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub tbFirstName_TextChanged(sender As Object, e As EventArgs)

        End Sub

        Private Sub guna2Button1_Click(sender As Object, e As EventArgs)
            clsBussnesLayer.UpdateType(_N, tbTypeName.Text, Convert.ToDouble(tbFees.Text))
        End Sub

    End Class
End Namespace
