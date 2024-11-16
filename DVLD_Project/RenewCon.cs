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
    public partial class RenewCon : UserControl
    {

        public RenewCon()
        {
            InitializeComponent();
        }

        public int GetAppID()
        {
            return Convert.ToInt32(lblAppID.Text);
        }


        public DateTime GetIssuedDateTime()
        {
            if (lblIssueDate.Text == "N/A")
            {
                return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            }
            return Convert.ToDateTime(lblIssueDate.Text);
        }

        public string GetNotes()
        {
            return tbNotes.Text;
        }

        public int GetCurrentLicense()
        {
            return Convert.ToInt32(lblNewLocalID.Text);
        }

        public void LoadInformations(int DriverID,int LicenseClass)
        {
            DataTable dt = clsBussnesLayer.GetOldNewLicense(DriverID,LicenseClass);
            int i = 0;
            
            if(dt != null)
            {
                foreach(DataRow dr in dt.Rows)
                { 
                    if (i == 0)
                    {
                        lblAppDate.Text = dr["ApplicationID"].ToString();
                        lblAppID.Text = dr["ApplicationID"].ToString();
                        lblAppFees.Text = dr["PaidFees"].ToString();
                        lblCreatedBy.Text = dr["UserName"].ToString();
                        lblExplationDate.Text = dr["ExpirationDate"].ToString();
                        lblIssueDate.Text = dr["IssueDate"].ToString();
                        lblLicenseFees.Text = dr["ClassFees"].ToString();
                        lblNewLocalID.Text = dr["LicenseID"].ToString();
                        double TF = Convert.ToDouble(lblAppFees.Text) + Convert.ToDouble(lblLicenseFees.Text);
                        lblTotalFees.Text = TF.ToString();
                        tbNotes.Text = dr["Notes"].ToString();
                       
                        i++;
                    }
                    else
                    {
                        lblOldLocalID.Text = dr["LicenseID"].ToString();
                       
                        break;
                    }

                }
            }
            else
            {
                lblAppDate.Text = "N/A";
                lblAppID.Text ="N/A";
                lblAppFees.Text = "N/A";
                lblCreatedBy.Text ="N/A";
                lblExplationDate.Text = "N/A";
                lblIssueDate.Text = "N/A";
                lblLicenseFees.Text = "N/A";
                lblNewLocalID.Text ="N/A";
                lblTotalFees.Text = "N/A";
                tbNotes.Text = "N/A";
                lblOldLocalID.Text = "N/A";

            }
        }

        public DateTime getDate()
        {
            if (lblExplationDate.Text=="N/A")
            {
                return new DateTime( DateTime.Now.Year-1,DateTime.Now.Month, DateTime.Now.Day);
            }
            return Convert.ToDateTime(lblExplationDate.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblAppID_Click(object sender, EventArgs e)
        {

        }

        private void RenewCon_Load(object sender, EventArgs e)
        {

        }
    }
}
