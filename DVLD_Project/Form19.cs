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
    public partial class Form19 : Form
    {
        int _ExamMode = 0;
        string NO = "";
        public Form19()
        {
            InitializeComponent();
        }

        public Form19(int ExamMode)
        {
            InitializeComponent();
            if (ExamMode == 2)
            {
                pictureBox1.Image = Resources.icons8_compose_641;
                //label1.Text = "Written Test";
            }
            else if (ExamMode == 3)
            {
                pictureBox1.Image = Resources.icons8_car_64;
                // label1.Text = "Driving Test";
            }
            _ExamMode = ExamMode;
        }
        int _APP = 0;
        public Form19(int AppID,int ExamMode, int DL, int TestID, int ClassID)
        {
            InitializeComponent();
            _APP = AppID;
            testMainInformations1.LoadControal("Read", ExamMode, DL, TestID, ClassID);
            //testMainInformations1.LoadControal(Mode,DL,TestID,ClassID);
            if (ExamMode == 2)
            {
                pictureBox1.Image = Resources.icons8_compose_641;
             
                //label1.Text = "Written Test";
            }
            else if (ExamMode == 3)
            {
                pictureBox1.Image = Resources.icons8_car_64;
                // label1.Text = "Driving Test";
              
            }
            _ExamMode=ExamMode;
          
        }

        public void LoadNetionalNumber(string Num)
        {
            NO = Num;
        }

        private void Form19_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int _PersonID = 0; 
            clsBussnesLayer.AddTest(0,_APP, rbPass.Checked, guna2TextBox1.Text, clsBussnesLayer.GetUserID());
            clsBussnesLayer.LockTestA(_APP);
            if (_ExamMode==3 && rbPass.Checked)
            {
                DataTable dt= clsBussnesLayer.FindWithFilters(0, "NationalNo", NO);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        _PersonID = Convert.ToInt32(dr[0]);
                        break;
                    }
                }
                clsBussnesLayer.AddDriver(0,_PersonID, clsBussnesLayer.GetUserID(), DateTime.Now);
            }
        }

        private void testMainInformations1_Load(object sender, EventArgs e)
        {

        }
    }
}
