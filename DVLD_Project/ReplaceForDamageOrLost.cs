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
    public partial class ReplaceForDamageOrLost : UserControl
    {
        public ReplaceForDamageOrLost()
        {
            InitializeComponent();
        }

        public int GetAppID()
        {
            return Convert.ToInt32(lblAppID.Text);
        }
      

        public int GetCurrentLicense()
        {
            return Convert.ToInt32(lblNewLocalID.Text);
        }

        public void LoadInformations(int DriverID, int LicenseClass)
        {
            DataTable dt = clsBussnesLayer.GetOldNewLicense(DriverID, LicenseClass);
            int i = 0;

            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (i == 0)
                    {
                        lblAppDate.Text = dr["ApplicationID"].ToString();
                        lblAppID.Text = dr["ApplicationID"].ToString();
                        lblAppFees.Text = dr["PaidFees"].ToString();
                        lblCreatedBy.Text = dr["UserName"].ToString();
                        lblNewLocalID.Text = dr["LicenseID"].ToString();

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
                lblAppID.Text = "N/A";
                lblAppFees.Text = "N/A";
                lblCreatedBy.Text = "N/A";               
                lblNewLocalID.Text = "N/A";              
                lblOldLocalID.Text = "N/A";

            }
        }

      


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ReplaceForDamageOrLost_Load(object sender, EventArgs e)
        {
            
        }

        public void SetPrice(int Price)
        {
            lblAppFees.Text= Price.ToString();
        }

        private void lblAppFees_Click(object sender, EventArgs e)
        {

        }
    }
}
