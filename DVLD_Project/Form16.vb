Imports System
Imports System.Windows.Forms
Imports BussnessLayerForDVLD
Imports DVLD_Project.Properties


Namespace DVLD_Project
    Public Partial Class Form16
        Inherits Form
        Private _ClassName As String = "", _NetionalNo As String = ""
        Private _AppID As Integer = 0, _TestsDone As Integer = 0, _DL As Integer = 0, _ExamMode As Integer = 0, _ClassID As Integer = 0
        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(AppID As Integer, ClassName As String, TestsDone As Integer, NetionalNo As String, ExamMode As Integer, DL As Integer, ClassID As Integer)
            InitializeComponent()
            _AppID = AppID
            _ClassName = ClassName
            _TestsDone = TestsDone
            _NetionalNo = NetionalNo
            _ExamMode = ExamMode
            _DL = DL
            _ClassID = ClassID
            If ExamMode = 2 Then
                pictureBox1.Image = Resources.icons8_compose_641
                label1.Text = "Written Test"
            ElseIf ExamMode = 3 Then
                pictureBox1.Image = Resources.icons8_car_64
                label1.Text = "Driving Test"
            End If

        End Sub

        Private Sub guna2Button1_Click(sender As Object, e As EventArgs)
            If clsBussnesLayer.CheckToADD(_DL, _ExamMode) = 1 Then
                Dim form20 As Form20 = New Form20("Add", _ExamMode, _DL, _ExamMode, _ClassID)
                form20.ShowDialog()
            Else
                MessageBox.Show("8888")
            End If
        End Sub

        Private Sub takeExamToolStripMenuItem_Click(sender As Object, e As EventArgs)
            Dim form19 As Form19 = New Form19(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells(0).Value), _ExamMode, _DL, _ExamMode, _ClassID)
            form19.ShowDialog()
        End Sub

        Private Sub editDateToolStripMenuItem_Click(sender As Object, e As EventArgs)
            Dim form20 As Form20 = New Form20("EDITE", _ExamMode, _DL, _ExamMode, _ClassID)
            form20.loadAppID(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells(0).Value))
            form20.ShowDialog()
        End Sub

        Public Sub setid(AppID As Integer, ClassName As String, TestsDone As Integer, NetionalNo As String)
            _AppID = AppID
            _ClassName = ClassName
            _TestsDone = TestsDone
            _NetionalNo = NetionalNo
        End Sub



        Public Sub LoadApp(_AppID As Integer)

        End Sub

        Private Sub Form16_Load(sender As Object, e As EventArgs)
            getApplcationBisicInformations1.GetInfo(_AppID)
            guna2DataGridView1.DataSource = clsBussnesLayer.GetAllTestsForOneType(_ExamMode, getApplcationBisicInformations1.GetDL())

            getAppInfo1.LoadInformations(_AppID, _ClassName, _TestsDone)
        End Sub
    End Class
End Namespace
