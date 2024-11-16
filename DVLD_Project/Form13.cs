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
    public partial class Form13 : Form
    {
        int _I = 0;
        string _N = "", _O = "";
        double _F = 0.0;
        public Form13()
        {
            InitializeComponent();
        }

        public Form13(int I,string N,string O,double F)
        {
            InitializeComponent();
            _I = I;
            _N = N;
            _O = O;
            _F = F;
            lblTypeID.Text=I.ToString();
            tbTestName.Text=N.ToString();
            tbNote.Text=O.ToString();
            tbFees.Text=F.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            clsBussnesLayer.UpdateTestType(_I, tbTestName.Text, tbNote.Text,Convert.ToDouble( tbFees.Text));
        }
    }
}
