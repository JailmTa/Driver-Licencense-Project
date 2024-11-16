Imports BussnessLayerForDVLD
Imports DVLD_Project.Properties
Imports System
Imports System.Windows.Forms

Namespace DVLD_Project
    Public Partial Class Form20
        Inherits Form
        Private _Fees As Single = 10.0F
        Private _ExamMode As Integer = 0, _DL As Integer = 0, _APPID As Integer = 0
        Private _Mode As String = ""
        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(Mode As String, ExamMode As Integer, DL As Integer, TestID As Integer, ClassID As Integer)
            InitializeComponent()
            _Mode = Mode
            _ExamMode = ExamMode
            _DL = DL
            testMainInformations1.LoadControal(Mode, ExamMode, DL, TestID, ClassID)
            'testMainInformations1.LoadControal(Mode,DL,TestID,ClassID);
            If ExamMode = 2 Then
                pictureBox1.Image = Resources.icons8_compose_641
                'label1.Text = "Written Test";
                _Fees = 20.0F
            ElseIf ExamMode = 3 Then
                pictureBox1.Image = Resources.icons8_car_64
                ' label1.Text = "Driving Test";
                _Fees = 30.0F
            End If
            Dim t As Integer = testMainInformations1.GetTotalTryes()
            If t = 0 OrElse Equals(_Mode, "EDITE") Then
                reTakeExam1.Enabled = False
            Else

                reTakeExam1.Enabled = True
            End If
            reTakeExam1.LoadControl(t, _Fees)
        End Sub


        Public Sub loadAppID(AppID As Integer)
            _APPID = AppID

        End Sub

        Private Sub Form20_Load(sender As Object, e As EventArgs)

        End Sub

        Private Sub testMainInformations1_Load(sender As Object, e As EventArgs)

        End Sub

        Private Sub guna2Button1_Click(sender As Object, e As EventArgs)
            If Equals(_Mode, "Add") Then
                Dim _TestA As Integer = clsBussnesLayer.AddTestA(0, _ExamMode, _DL, Date.Now, reTakeExam1.GetTotalFees(), clsBussnesLayer.GetUserID(), False)
            Else
                Dim _TestA As Integer = clsBussnesLayer.UpDateTestAPPDate(_APPID, testMainInformations1.GetNewDateTime())
            End If

        End Sub
    End Class
End Namespace
