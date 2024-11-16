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
    public partial class Form28 : Form
    {
        public Form28()
        {
            InitializeComponent();
            guna2Button1.Enabled = true;
            linkLabel2.Enabled = true;
            radioButton1.Checked = true;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text != "")
                licensInformations1.LoadInfo(Convert.ToInt32(guna2TextBox1.Text));

            replaceForDamageOrLost1.SetPrice(10);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            replaceForDamageOrLost1.SetPrice(10);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            replaceForDamageOrLost1.SetPrice(5);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
         clsBussnesLayer.RePlaceForDamageLicense(licensInformations1.GetAppID(),clsBussnesLayer.GetUserID(),licensInformations1.GetLisemceID());
            if(radioButton2.Checked)
                clsBussnesLayer.RePlaceForDamageLicense(licensInformations1.GetAppID(), clsBussnesLayer.GetUserID(), licensInformations1.GetLisemceID());
            else
               clsBussnesLayer.RePlaceForLostLicense(licensInformations1.GetAppID(), clsBussnesLayer.GetUserID(), licensInformations1.GetLisemceID());
            replaceForDamageOrLost1.LoadInformations(licensInformations1.GetDriverID(), licensInformations1.GetLicense());
        }

        private void Form28_Load(object sender, EventArgs e)
        {

        }

        private void licensInformations1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form21 form21 = new Form21();
            form21.LoadInfo(licensInformations1.GetLisemceID());
            form21.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form23 form23 = new Form23(licensInformations1.GetDriverID());
            form23.ShowDialog();
        }
    }
}
