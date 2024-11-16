using BussnessLayerForDVLD;
using DVLD_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class Form20 : Form
    {
        float _Fees = 10.0f; int _ExamMode = 0, _DL = 0, _APPID = 0;
        string _Mode = "";
        public Form20()
        {
            InitializeComponent();
        }

        public Form20(string Mode, int ExamMode, int DL, int TestID, int ClassID)
        {
            InitializeComponent();
            _Mode = Mode;
            _ExamMode = ExamMode;
            _DL = DL;
            testMainInformations1.LoadControal(Mode, ExamMode, DL, TestID, ClassID);
            //testMainInformations1.LoadControal(Mode,DL,TestID,ClassID);
            if (ExamMode == 2)
            {
                pictureBox1.Image = Resources.icons8_compose_641;
                _Fees = 20.0f;
                //label1.Text = "Written Test";
            }
            else if (ExamMode == 3)
            {
                pictureBox1.Image = Resources.icons8_car_64;
                // label1.Text = "Driving Test";
                _Fees = 30.0f;
            }
            int t = testMainInformations1.GetTotalTryes();
            if (t == 0 || _Mode == "EDITE")
            {
                reTakeExam1.Enabled = false;
            }
            else
            {

                reTakeExam1.Enabled = true;
            }
            reTakeExam1.LoadControl(t, _Fees);
        }


        public void loadAppID(int AppID)
        {
            _APPID = AppID;

        }

        private void Form20_Load(object sender, EventArgs e)
        {

        }

        private void testMainInformations1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (_Mode == "Add")
            {
                int _TestA = clsBussnesLayer.AddTestA(0, _ExamMode, _DL, DateTime.Now, reTakeExam1.GetTotalFees(), clsBussnesLayer.GetUserID(), false);
            }
            else
            {
                int _TestA = clsBussnesLayer.UpDateTestAPPDate(_APPID, testMainInformations1.GetNewDateTime());
            }

        }
    }
}
