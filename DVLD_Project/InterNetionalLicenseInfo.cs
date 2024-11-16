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
    public partial class InterNetionalLicenseInfo : UserControl
    {
        int _DriverID = 0;
        public InterNetionalLicenseInfo()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public int GetIL()
        {
            int Num = 0;
            Num = int.Parse(lblInterNetionalID.Text);
            return Num;
        }

        public void LoadInfo(int DriverID)
        {
            _DriverID= DriverID;
            DataTable dt = clsBussnesLayer.GetInterNationalInfoCon(DriverID);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    lblAppID.Text = dr["ApplicationID"].ToString();
                    lblAppDate.Text = dr["ApplicationDate"].ToString();
                    lblCreatedBy.Text = dr["UserName"].ToString();
                    lblExplationDate.Text = dr["ExpirationDate"].ToString();
                    lblFees.Text = dr["PaidFees"].ToString();
                    lblInterNetionalID.Text = dr["InternationalLicenseID"].ToString();
                    lblIssueDate.Text = dr["IssueDate"].ToString();
                    lblLocalID.Text = dr["IssuedUsingLocalLicenseID"].ToString();
                }
            }
            else
            {
                lblAppID.Text = "N/A";
                lblAppDate.Text = "N/A";
                lblCreatedBy.Text ="N/A";
                lblExplationDate.Text ="N/A";
                lblFees.Text = "N/A";
                lblInterNetionalID.Text ="N/A";
                lblIssueDate.Text = "N/A";
                lblLocalID.Text = "N/A";
            }
        }

        private void InterNetionalLicenseInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
