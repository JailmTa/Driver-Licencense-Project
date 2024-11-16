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
using Guna.UI2.WinForms;

namespace DVLD_Project
{
    public partial class Form29 : Form
    {
        public Form29()
        {
            InitializeComponent();
        }

        public Form29(int LID)
        {
            InitializeComponent();
            guna2TextBox1.Text = LID.ToString();
            licensInformations1.LoadInfoByLicenseID(Convert.ToInt32(guna2TextBox1.Text));
            int Num = detaienLicense1.LoadInformation(licensInformations1.GetLisemceID());
            if (Num == 1)
            {
                MessageBox.Show("8888");
                guna2Button1.Enabled = false;
            }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int DetingID = clsBussnesLayer.AddDetin(0,licensInformations1.GetLisemceID(),DateTime.Now,detaienLicense1.GetFees(),clsBussnesLayer.GetUserID());
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text != "")
            {
                licensInformations1.LoadInfo(Convert.ToInt32(guna2TextBox1.Text));
                int Num = detaienLicense1.LoadInformation(licensInformations1.GetLisemceID());
                if (Num==1)
                {
                    MessageBox.Show("8888");
                    guna2Button1.Enabled=false;
                }
            }
            
        }

        private void Form29_Load(object sender, EventArgs e)
        {

        }

       

        private void licensInformations1_Load(object sender, EventArgs e)
        {

        }
    }
}
