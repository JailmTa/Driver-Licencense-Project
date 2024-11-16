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
    public partial class Form27 : Form
    {
        public Form27()
        {
            InitializeComponent();
            linkLabel2.Enabled = false;
        }

        private void Form27_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text != "")
                licensInformations1.LoadInfo(Convert.ToInt32(guna2TextBox1.Text));
           
            renewCon1.LoadInformations(licensInformations1.GetDriverID(), licensInformations1.GetLicense());
            if (renewCon1.getDate() > DateTime.Now)
            {
                MessageBox.Show("888");

                guna2Button1.Enabled = false;
                linkLabel2.Enabled = true;
            }
            else
            {
                guna2Button1.Enabled = true;
                linkLabel2.Enabled = true;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DateTime d = new DateTime(DateTime.Now.Year + 10, DateTime.Now.Month, DateTime.Now.Day);
            clsBussnesLayer.ReNewLicense(renewCon1.GetAppID(),DateTime.Now,d,renewCon1.GetNotes(),clsBussnesLayer.GetUserID(),renewCon1.GetCurrentLicense());
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form21 form21 = new Form21();
            form21.LoadInfo(renewCon1.GetCurrentLicense());
            form21.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form23 form23 = new Form23(licensInformations1.GetDriverID());
            form23.ShowDialog();
        }

        private void licensInformations1_Load(object sender, EventArgs e)
        {

        }
    }
}
