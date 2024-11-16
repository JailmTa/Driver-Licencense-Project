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
    public partial class DetaienLicense : UserControl
    {
        public DetaienLicense()
        {
            InitializeComponent();
        }
        float _Fees = 0;

        private void DetaienLicense_Load(object sender, EventArgs e)
        {

        }

        private void tbFees_TextChanged(object sender, EventArgs e)
        {

            if (!float.TryParse(tbFees.Text, out _Fees))
            {
                tbFees.Clear();
            }
        }

        public float GetFees()
        {
            return _Fees;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public int LoadInformation(int LID)
        {
            DataTable dt = clsBussnesLayer.FindDetint(LID);
            if (dt!=null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    lblDetiningID.Text = dr["DetainID"].ToString();
                    lblAppDate.Text= dr["DetainDate"].ToString();
                    lblLicense.Text = dr["LicenseID"].ToString();
                    lblCreatedBy.Text = dr["CreatedByUserID"].ToString();
                    tbFees.Text = dr["FineFees"].ToString();
                    tbFees.Enabled = false;
                    return 1;
                }
            }
            else
            {
                lblDetiningID.Text = "N/A";
                lblAppDate.Text = "N/A";
                lblLicense.Text = "N/A";
                lblCreatedBy.Text = "N/A";
                tbFees.Text = "0.0";
                tbFees.Enabled = true;
              
            }
            return 0;
        }

        private void lblDetiningID_Click(object sender, EventArgs e)
        {
           
        }
    }
}
