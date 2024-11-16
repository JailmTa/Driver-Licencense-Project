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
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }

        private void licensInformations1_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text != "")
                licensInformations1.LoadInfo(Convert.ToInt32(guna2TextBox1.Text));
            if (clsBussnesLayer.CheckForAddInterNational(licensInformations1.GetDriverID()))
            {
                MessageBox.Show("888");
                interNetionalLicenseInfo1.LoadInfo(licensInformations1.GetDriverID());
                guna2Button1.Enabled = false;
            }
            else
            {
                interNetionalLicenseInfo1.LoadInfo(0);
                guna2Button1.Enabled = true;
            }
        }

        private void Form24_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int Internetional = clsBussnesLayer.AddInterNationalLicense(0, licensInformations1.GetDriverID(), licensInformations1.GetLisemceID(), DateTime.Now, new DateTime(DateTime.Now.Year + 10, DateTime.Now.Month, DateTime.Now.Day), true, clsBussnesLayer.GetUserID());

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form26 form26 = new Form26(interNetionalLicenseInfo1.GetIL());
            form26.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form23 form23 = new Form23(licensInformations1.GetDriverID());
            form23.ShowDialog();
        }
    }
}
