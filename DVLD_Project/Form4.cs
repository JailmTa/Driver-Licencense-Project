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
    public partial class Form4 : Form
    {
        int _PersonID = 0;
        string _NationalID="";
        public Form4()
        {
            InitializeComponent();
        }

        public Form4(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            getInformations2.GetInfo(_PersonID);
        }

        public Form4(string NationalID)
        {
            InitializeComponent();
            _NationalID =NationalID;
            getInformations2.GetInfoNetionalNo(NationalID);
        }

        public void GetInfoByDriverID(int DriverID)
        {
            getInformations2.GetInfoByDriverID(DriverID);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void getInformations2_Load(object sender, EventArgs e)
        {

        }

        private void getInformations2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
