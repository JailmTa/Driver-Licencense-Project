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
    public partial class Form21 : Form
    {
        int _DL=0;
        public Form21(int DL)
        {
            InitializeComponent();
            _DL = DL;
            licensInformations1.LoadInfo(_DL);
        }

        public Form21()
        {
            InitializeComponent();
            
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            
        }
        public void LoadInfo(int LID)
        {
            licensInformations1.LoadInfoByLicenseID(LID);
        }

        private void licensInformations1_Load(object sender, EventArgs e)
        {

        }
    }
}
