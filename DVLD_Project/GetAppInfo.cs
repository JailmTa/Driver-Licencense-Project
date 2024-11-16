using Guna.UI2.WinForms;
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
    public partial class GetAppInfo : UserControl
    {
        public GetAppInfo()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblTypeID_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void LoadInformations(int AppID, string ClassName, int NumOfExamsHasDone)
        {

            lblAppID.Text = AppID.ToString();
            lblClassName.Text = ClassName.ToString();
            lblExamsDone.Text = NumOfExamsHasDone.ToString() + "/3 - Has Done !..";
            if (NumOfExamsHasDone==3)
            {
                linkLabel1.Enabled = true;
            }
            else
            {
                linkLabel1.Enabled = false;
            }

        }

        private void GetAppInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
