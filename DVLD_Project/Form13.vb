Imports BussnessLayerForDVLD
Imports System
Imports System.Windows.Forms

Namespace DVLD_Project
    Public Partial Class Form13
        Inherits Form
        Private _I As Integer = 0
        Private _N As String = "", _O As String = ""
        Private _F As Double = 0.0
        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(I As Integer, N As String, O As String, F As Double)
            InitializeComponent()
            _I = I
            _N = N
            _O = O
            _F = F
            lblTypeID.Text = I.ToString()
            tbTestName.Text = N.ToString()
            tbNote.Text = O.ToString()
            tbFees.Text = F.ToString()
        End Sub

        Private Sub guna2Button1_Click(sender As Object, e As EventArgs)
            clsBussnesLayer.UpdateTestType(_I, tbTestName.Text, tbNote.Text, Convert.ToDouble(tbFees.Text))
        End Sub
    End Class
End Namespace
