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
    public partial class GetApplcationBisicInformations : UserControl
    {
        int AppID = 0,_DL=0;
        string _NetionalNo = "";
      
        public GetApplcationBisicInformations()
        {
            InitializeComponent();
        }

      

     

        private void GetApplcationBisicInformations_Load(object sender, EventArgs e)
        {
          
        }

        public void GetInfo(int AppID)
        {
            this.AppID= AppID;
            DataTable dt = clsBussnesLayer.FindApplcations(AppID);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    _DL = Convert.ToInt32(row["LocalDrivingLicenseApplicationID"].ToString());
                    lblAppID.Text = row["ApplicationID"].ToString();
                    lblCreatedBy.Text = row["UserName"].ToString();
                    lblDate.Text = row["ApplicationDate"].ToString();
                    lblFees.Text = row["PaidFees"].ToString();
                    lblName.Text = row["FirstName"].ToString()+" " + row["SecondName"].ToString() + " " + row["ThirdName"].ToString() + " " + row["LastName"].ToString();
                    lblStatues.Text = row["ApplicationStatus"].ToString();
                    _NetionalNo = row["NationalNo"].ToString();
                    lblStutesDate.Text = row["LastStatusDate"].ToString();
                    lblType.Text = row["ApplicationTypeTitle"].ToString();
                   
                    break;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3=new Form3(_NetionalNo);
            form3.ShowDialog();
        }

        public int GetDL()
        {
            return _DL;
        }
    }
}
