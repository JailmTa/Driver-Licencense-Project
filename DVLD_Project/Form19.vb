Imports BussnessLayerForDVLD
Imports DVLD_Project.Properties
Imports System
Imports System.Windows.Forms

Namespace DVLD_Project
    Public Partial Class Form19
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(ExamMode As Integer)
            InitializeComponent()
            If ExamMode = 2 Then
                'label1.Text = "Written Test";
                pictureBox1.Image = Resources.icons8_compose_641
            ElseIf ExamMode = 3 Then
                pictureBox1.Image = Resources.icons8_car_64
                ' label1.Text = "Driving Test";
            End If
        End Sub
        Private _APP As Integer = 0
        Public Sub New(AppID As Integer, ExamMode As Integer, DL As Integer, TestID As Integer, ClassID As Integer)
            InitializeComponent()
            _APP = AppID
            testMainInformations1.LoadControal("Read", ExamMode, DL, TestID, ClassID)
            'testMainInformations1.LoadControal(Mode,DL,TestID,ClassID);
            If ExamMode = 2 Then

                'label1.Text = "Written Test";
                pictureBox1.Image = Resources.icons8_compose_641
            ElseIf ExamMode = 3 Then
                pictureBox1.Image = Resources.icons8_car_64
                ' label1.Text = "Driving Test";

            End If

        End Sub

        Private Sub Form19_Load(sender As Object, e As EventArgs)

        End Sub

        Private Sub guna2Button1_Click(sender As Object, e As EventArgs)

            clsBussnesLayer.AddTest(0, _APP, rbPass.Checked, guna2TextBox1.Text, clsBussnesLayer.GetUserID())
            clsBussnesLayer.LockTestA(_APP)
        End Sub
    End Class
End Namespace
