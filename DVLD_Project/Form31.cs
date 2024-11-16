using DVLD_Project;
using Guna.UI2.WinForms;
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
    public partial class Form31 : Form
    {
        public Form31()
        {
            InitializeComponent();
        }

        public Form31(int LID)
        {
            InitializeComponent();
            guna2TextBox1.Text = LID.ToString();
            licensInformations1.LoadInfoByLicenseID(Convert.ToInt32(guna2TextBox1.Text));
            int Num = getDetolesTotRelaseDetiningLicense1.LoadInformation(licensInformations1.GetLisemceID());
            if (Num == 1)
            {
                MessageBox.Show("8888");
                guna2Button1.Enabled = false;
            }

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text != "")
            {
                licensInformations1.LoadInfo(Convert.ToInt32(guna2TextBox1.Text));
                int Num = getDetolesTotRelaseDetiningLicense1.LoadInformation(licensInformations1.GetLisemceID());
                if (Num == 0)
                {
                    guna2Button1.Enabled = false;
                }
                else
                {
                    guna2Button1.Enabled = true;
                    clsBussnesLayer.UpDateDetin(getDetolesTotRelaseDetiningLicense1.GetDe(), DateTime.Now,clsBussnesLayer.GetUserID());
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void licensInformations1_Load(object sender, EventArgs e)
        {

        }

        private void Form31_Load(object sender, EventArgs e)
        {

        }
    }
}
