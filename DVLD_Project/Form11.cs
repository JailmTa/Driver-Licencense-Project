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
    public partial class Form11 : Form
    {
        int _N = 0;
        string _T = "";
        double _F = 0.0f;
        public Form11()
        {
            InitializeComponent();
        }

        public Form11(int N, string T, double F)
        {
            InitializeComponent();
            lblTypeID.Text = N.ToString();
            tbTypeName.Text = T.ToString();
            tbFees.Text = F.ToString();
            _N = N;
            _T = T;
            _F = F;
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            clsBussnesLayer.UpdateType(_N,tbTypeName.Text,Convert.ToDouble(tbFees.Text));
        }
    
    }
}
