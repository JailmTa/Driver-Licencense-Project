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
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }

        public Form26(int IL)
        {
            InitializeComponent();
            internationalInformaion1.LoadInfo(IL);
        }


        private void Form26_Load(object sender, EventArgs e)
        {

        }
    }
}
