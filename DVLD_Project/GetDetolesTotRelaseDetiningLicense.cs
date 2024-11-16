using BussnessLayerForDVLD;
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
    public partial class GetDetolesTotRelaseDetiningLicense : UserControl
    {
        int _De = 0;
        public GetDetolesTotRelaseDetiningLicense()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public int GetDe()
        {
            return _De;
        }

        public int LoadInformation(int LID)
        {
            DataTable dt = clsBussnesLayer.FindDetint(LID);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    lblDetiningID.Text = dr["DetainID"].ToString();
                    _De=Convert.ToInt32(lblDetiningID.Text);
                    lblAppDate.Text = dr["DetainDate"].ToString();
                    lblLicense.Text = dr["LicenseID"].ToString();
                    lblCreatedBy.Text = dr["UserName"].ToString();
                    lblAppFees.Text = dr["ApplicationFees"].ToString();
                    lblFees.Text = dr["FineFees"].ToString();
                    lblTotalFees.Text = dr["TotalFees"].ToString();
                    lblRelLicenseAppID.Text = dr["ReleaseApplicationID"].ToString();
                    return 1;
                }
            }
            else
            {
                lblDetiningID.Text = "N/A";
                _De = 0;
               lblAppDate.Text = "N/A";
                lblLicense.Text = "N/A";
                lblCreatedBy.Text = "N/A";
                lblAppFees.Text = "0.0";
                lblFees.Text = "0.0";
                lblTotalFees.Text = "0.0";
                lblRelLicenseAppID.Text = "N/A";

            }
            return 0;
        }
    }
}
