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

namespace DVLD_Project
{
    public partial class TestMainInformations : UserControl
    {
        public TestMainInformations()
        {
            InitializeComponent();
        }


        public void LoadControal(string Mode)
        {
            if (Mode == "Read")
            {
                dateTimePicker1.Visible = false;
                lblTestDate.Visible = true;
            }
            else
            {
                dateTimePicker1.Visible = true;
                lblTestDate.Visible = false;
            }
        }

        public void LoadControal(string Mode,int ExamMode,int DL,int TestID,int ClassID)
        {
            DataTable dt = clsBussnesLayer.GetInfoTest(DL,TestID,ClassID);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {

                    lblAppID.Text = dr["LocalDrivingLicenseApplicationID"].ToString();
                    lblName.Text = dr["FullName"].ToString();
                    lblType.Text= dr["ClassName"].ToString();
                    lblFees.Text = "10";
                    lblTrye.Text = dr["Trayes"].ToString();
                }
            }
            if (Mode == "Read")
            {
                dateTimePicker1.Visible = false;
                lblTestDate.Visible = true;
            }
            else
            {
                dateTimePicker1.Visible = true;
                lblTestDate.Visible = false;
            }

        }

        public int GetTotalTryes()
        {
            int Num = 0;
            int.TryParse(lblTrye.Text, out Num);
            return  Num;
        }

        private void TestMainInformations_Load(object sender, EventArgs e)
        {

        }
        public DateTime GetNewDateTime()
        {
            return dateTimePicker1.Value;
        }
    }
}
