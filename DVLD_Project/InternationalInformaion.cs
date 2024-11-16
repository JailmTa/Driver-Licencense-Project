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
    public partial class InternationalInformaion : UserControl
    {
        public InternationalInformaion()
        {
            InitializeComponent();
        }

        public void LoadInfo(int IL)
        {
            DataTable dt = clsBussnesLayer.GetInternationalLicenseInformationsForCon(IL);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    lblName.Text = dr["FullName"].ToString();
                    if (dr["Gendor"].ToString() == "M") 
                    {
                        lblGonder.Text = "Male";
                        pictureBox9.Image = Resources.icons8_male_64;
                    }
                    else
                    {
                        lblGonder.Text = "Femal";
                        pictureBox9.Image = Resources.icons8_female_64;
                    }
                    lblInterNetionalID.Text = dr["InternationalLicenseID"].ToString();
                    lblIsActive.Text = dr["IsActive"].ToString();
                    lblLocalID.Text = dr["IssuedUsingLocalLicenseID"].ToString();
                    lblNationalNo.Text = dr["NationalNo"].ToString();
                    lblBirthDate.Text = dr["DateOfBirth"].ToString();
                    lblAppID.Text = dr["ApplicationID"].ToString();
                    lblIssueDate.Text= dr["IssueDate"].ToString();
                    lblExplationDate.Text = dr["ExpirationDate"].ToString();
                    lblDriverID.Text = dr["DriverID"].ToString();
                    if (dr["ImagePath"].ToString() !="")
                    {
                        pbProfile.Image = Image.FromFile(dr["ImagePath"].ToString());
                    }
                }

            }
        }




        private void lblFees_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
