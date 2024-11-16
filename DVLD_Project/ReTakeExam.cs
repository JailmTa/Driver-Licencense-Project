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
    public partial class ReTakeExam : UserControl
    {
        public ReTakeExam()
        {
            InitializeComponent();
        }

        public void LoadControl(int NumberOfExamsBefor,float ExamFees)
        {
            if (NumberOfExamsBefor==0)
            {
                lblFeesR.Text = "0";
                lblFeesT.Text = ExamFees.ToString();
            }
            else
            {
                lblFeesR.Text = "5";
                lblFeesT.Text = (5f+ExamFees).ToString();
            }
        }

        public float GetTotalFees()
        {
            return float.Parse(lblFeesT.Text.ToString());
        }

        private void ReTakeExam_Load(object sender, EventArgs e)
        {

        }
    }
}
