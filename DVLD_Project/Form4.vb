Imports System
Imports System.Windows.Forms

Namespace DVLD_Project
    Public Partial Class Form4
        Inherits Form
        Private _PersonID As Integer = 0
        Private _NationalID As String = ""
        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(PersonID As Integer)
            InitializeComponent()
            _PersonID = PersonID
            getInformations2.GetInfo(_PersonID)
        End Sub

        Public Sub New(NationalID As String)
            InitializeComponent()
            _NationalID = NationalID
            getInformations2.GetInfoNetionalNo(NationalID)
        End Sub
        Private Sub Form4_Load(sender As Object, e As EventArgs)

        End Sub

        Private Sub getInformations2_Load(sender As Object, e As EventArgs)

        End Sub

        Private Sub getInformations2_Load_1(sender As Object, e As EventArgs)

        End Sub
    End Class
End Namespace
