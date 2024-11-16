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
    public partial class Form23 : Form
    {
        int _DL = 0;
        string _Ne = "";
        public Form23()
        {
            InitializeComponent();
        }

        public Form23(int DriverID)
        {
            InitializeComponent();
            guna2DataGridView1.DataSource=clsBussnesLayer.GetInternationalLicenseInformationsForDriver(DriverID);
            guna2DataGridView2.DataSource=clsBussnesLayer.GetInterLicenseInfoByDriverID(DriverID);
            getInformations1.GetInfoByDriverID(DriverID);
            
        }


        public Form23(int DL,string Ne)
        {
            InitializeComponent();
            _DL = DL;
            _Ne = Ne;
          
            getInformations1.GetInfoNetionalNo(_Ne);
            guna2DataGridView1.DataSource = clsBussnesLayer.GetLicenseInfoDgv(_DL);
            guna2DataGridView2.DataSource = clsBussnesLayer.GetInterLicenseInfoDgv(_DL);

        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                guna2DataGridView1.BringToFront();
            }
            else
            {
                guna2DataGridView2.BringToFront();
            }
        }

        private void Form23_Load(object sender, EventArgs e)
        {

        }
    }
}
