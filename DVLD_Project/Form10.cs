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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource= clsBussnesLayer.GetAllAppTypes();
        }

        private void upDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11(Convert.ToInt16( guna2DataGridView1.CurrentRow.Cells[0].Value), guna2DataGridView1.CurrentRow.Cells[1].Value.ToString(),Convert.ToDouble(  guna2DataGridView1.CurrentRow.Cells[2].Value));
            form11.Show();
        }
    }
}
