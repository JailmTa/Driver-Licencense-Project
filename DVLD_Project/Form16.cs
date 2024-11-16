using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussnessLayerForDVLD;
using DVLD_Project.Properties;


namespace DVLD_Project
{
    public partial class Form16 : Form
    {
        string _ClassName = "", _NetionalNo = "";
        int _AppID = 0, _TestsDone = 0, _DL = 0,_ExamMode=0,_ClassID=0;
        public Form16()
        {
            InitializeComponent();
        }

        public Form16(int AppID, string ClassName, int TestsDone, string NetionalNo,int ExamMode,int DL,int ClassID)
        {
            InitializeComponent();
            _AppID = AppID;
            _ClassName = ClassName;
            _TestsDone = TestsDone;
            _NetionalNo = NetionalNo;
            _ExamMode = ExamMode;
            _DL = DL;
            _ClassID = ClassID;
            if (ExamMode==2)
            {
                pictureBox1.Image = Resources.icons8_compose_641;
                label1.Text = "Written Test";
            }else if (ExamMode == 3)
            {
                pictureBox1.Image = Resources.icons8_car_64;
                label1.Text = "Driving Test";
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (clsBussnesLayer.CheckToADD(_DL, _ExamMode) == 1)
            {
                Form20 form20 = new Form20("Add", _ExamMode, _DL, _ExamMode, _ClassID);
                form20.ShowDialog();
            }
            else
            {
                MessageBox.Show("8888");
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void takeExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19(Convert.ToInt32( guna2DataGridView1.CurrentRow.Cells[0].Value),_ExamMode, _DL, _ExamMode, _ClassID);
            form19.LoadNetionalNumber(_NetionalNo);
            form19.ShowDialog();
        }

        private void editDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form20 form20 = new Form20("EDITE", _ExamMode, _DL, _ExamMode, _ClassID);
            form20.loadAppID(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value));
            form20.ShowDialog();
        }

        public void setid(int AppID, string ClassName, int TestsDone, string NetionalNo)
        {
            _AppID = AppID;
            _ClassName = ClassName;
            _TestsDone = TestsDone;
            _NetionalNo = NetionalNo;
        }



        public void LoadApp(int _AppID)
        {

        }

        private void Form16_Load(object sender, EventArgs e)
        {
            getApplcationBisicInformations1.GetInfo(_AppID);
            guna2DataGridView1.DataSource = clsBussnesLayer.GetAllTestsForOneType(_ExamMode, getApplcationBisicInformations1.GetDL());

            getAppInfo1.LoadInformations(_AppID, _ClassName, _TestsDone);
        }
    }
}
