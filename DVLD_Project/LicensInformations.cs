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
using Guna.UI2.WinForms;


namespace DVLD_Project
{
    public partial class LicensInformations : UserControl
    {
        int _DriverID = 0, _LisenceID = 0, _ClassID = 0, _AppID = 0;
        public LicensInformations()
        {
            InitializeComponent();
        }

        private void pbProfile_Click(object sender, EventArgs e)
        {

        }

        public void LoadInfo(int DL)
        {

            DataTable dt = clsBussnesLayer.GetLicenseInfo(DL);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    lblClass.Text = dr["ClassName"].ToString();
                    lblDateOfBirth.Text = dr["DateOfBirth"].ToString();
                    lblDriverID.Text = dr["DriverID"].ToString();
                    _DriverID = Convert.ToInt32(lblDriverID.Text);
                    lblE_Date.Text = dr["ExpirationDate"].ToString();
                    lblGonder.Text = dr["Gendor"].ToString();
                    lblIsActive.Text = dr["IsActive"].ToString();
                    lblIsDetained.Text = "NO";
                    lblIssueDate.Text = dr["IssueDate"].ToString();
                    lblIssueReason.Text = dr["IssueReason"].ToString();
                    lblName.Text = dr["FullName"].ToString();
                    lblNationlNo.Text = dr["NationalNo"].ToString();
                    lblNotes.Text = dr["Notes"].ToString();
                    lblLicense.Text = dr["LicenseID"].ToString();
                    _LisenceID = Convert.ToInt32(lblLicense.Text);
                      _AppID = Convert.ToInt32(dr["ApplicationID"].ToString());
                    if (dr["ImagePath"].ToString() != null)
                    {
                        pbProfile.Image = Image.FromFile(dr["ImagePath"].ToString());
                    }
                    try
                    {
                        if (Convert.ToInt32(dr["IsReleased"]) == 0)
                        {
                            lblIsDetained.Text = "YES";
                        }
                    }catch(Exception ex)
                    {
                        lblIsDetained.Text = "NO";
                    }
                }
                foreach (char c in lblClass.Text)
                {
                    string Text = c + " ";
                    int Num = 0;
                    int.TryParse(Text, out Num);
                    if (Num > 0)
                    {
                        _ClassID = Num;
                        break;
                    }
                }
            }
            else
            {
                lblClass.Text = "N/A";
                lblDateOfBirth.Text = "N/A";
                lblDriverID.Text = "N/A";
                lblE_Date.Text = "N/A";
                lblGonder.Text = "N/A";
                lblIsActive.Text = "N/A";
                lblIsDetained.Text = "NO";
                lblIssueDate.Text = "N/A";
                lblIssueReason.Text = "N/A";
                lblName.Text = "N/A";
                lblNationlNo.Text = "N/A";
                lblNotes.Text = "N/A";
                lblLicense.Text = "N/A";
                pbProfile.Image = Resources.icons8_male_64;
                _DriverID = 0;
                _LisenceID = 0;
                _AppID = 0;
            }
        }

        public void LoadInfoByLicenseID(int DL)
        {

            DataTable dt = clsBussnesLayer.GetLicenseInfov2(DL);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    lblClass.Text = dr["ClassName"].ToString();
                    lblDateOfBirth.Text = dr["DateOfBirth"].ToString();
                    lblDriverID.Text = dr["DriverID"].ToString();
                    _DriverID = Convert.ToInt32(lblDriverID.Text);
                    lblE_Date.Text = dr["ExpirationDate"].ToString();
                    lblGonder.Text = dr["Gendor"].ToString();
                    lblIsActive.Text = dr["IsActive"].ToString();
                    lblIsDetained.Text = "NO";
                    lblIssueDate.Text = dr["IssueDate"].ToString();
                    lblIssueReason.Text = dr["IssueReason"].ToString();
                    lblName.Text = dr["FullName"].ToString();
                    lblNationlNo.Text = dr["NationalNo"].ToString();
                    lblNotes.Text = dr["Notes"].ToString();
                    lblLicense.Text = dr["LicenseID"].ToString();
                    _LisenceID = Convert.ToInt32(lblLicense.Text);
                      _AppID = Convert.ToInt32(dr["ApplicationID"].ToString());
                    if (dr["ImagePath"].ToString() != null)
                    {
                        pbProfile.Image = Image.FromFile(dr["ImagePath"].ToString());
                    }
                    if (Convert.ToInt32(dr["IsReleased"]) == 0)
                    {
                        lblIsDetained.Text = "YES";
                    }
                }
                foreach (char c in lblClass.Text)
                {
                    string Text = c + " ";
                    int Num = 0;
                    int.TryParse(Text, out Num);
                    if (Num > 0)
                    {
                        _ClassID = Num;
                        break;
                    }
                }
            }
            else
            {
                lblClass.Text = "N/A";
                lblDateOfBirth.Text = "N/A";
                lblDriverID.Text = "N/A";
                lblE_Date.Text = "N/A";
                lblGonder.Text = "N/A";
                lblIsActive.Text = "N/A";
                lblIsDetained.Text = "NO";
                lblIssueDate.Text = "N/A";
                lblIssueReason.Text = "N/A";
                lblName.Text = "N/A";
                lblNationlNo.Text = "N/A";
                lblNotes.Text = "N/A";
                lblLicense.Text = "N/A";
                pbProfile.Image = Resources.icons8_male_64;
                _DriverID = 0;
                _LisenceID = 0;
                _AppID = 0;
            }
        }

        public int GetDriverID()
        {
            return _DriverID;
        }

        public int GetLicense()
        {
            return _ClassID;
        }

        public int GetLisemceID()
        {
            return _LisenceID;
        }

        public int GetAppID()
        {
            return _AppID;
        }


        private void LicensInformations_Load(object sender, EventArgs e)
        {

        }
    }
}
