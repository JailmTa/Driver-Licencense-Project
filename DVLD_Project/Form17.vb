Imports Guna.UI2.WinForms
Imports System
Imports System.Windows.Forms

Namespace DVLD_Project
    Public Partial Class Form17
        Inherits Form
        Private _NetionalNo As String = "", _ClassName As String = ""
        Private _AppID As Integer = 0, _TestsDone As Integer = 0
        Private _dt As Guna2DataGridView = New Guna2DataGridView()
        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(AppID As Integer, ClassName As String, TestsDone As Integer, NetionalNo As String)
            InitializeComponent()
            _AppID = AppID
            _ClassName = ClassName
            _TestsDone = TestsDone
            _NetionalNo = NetionalNo
        End Sub

        Private Sub Form17_Load(sender As Object, e As EventArgs)
            getInformations1.GetInfoNetionalNo(_NetionalNo)
            getAppInfo1.LoadInformations(_AppID, _ClassName, _TestsDone)
        End Sub
    End Class
End Namespace
