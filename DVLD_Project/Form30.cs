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
using BussnessLayerForDVLD;

namespace DVLD_Project
{
    public partial class Form30 : Form
    {
        public Form30()
        {
            InitializeComponent();
        }

        private void Form30_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource=clsBussnesLayer.GetAllDetinalLicense();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form29 form29   = new Form29(); 
            form29.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form31 form31 = new Form31();   
                form31.ShowDialog();
        }

        private void detiningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form29 form29 = new Form29(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[1].Value));
            form29.ShowDialog();
        }

        private void takeOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form31 form29 = new Form31(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[1].Value));
            form29.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if ((Boolean)guna2DataGridView1.CurrentRow.Cells[5].Value)
            {
                takeOffToolStripMenuItem.Enabled = false;
                detiningToolStripMenuItem.Enabled = true;
            }
            else
            {
                detiningToolStripMenuItem.Enabled = false;
                takeOffToolStripMenuItem.Enabled = true;
            }
        }

        private void personInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form23 form23 = new Form23(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[9].Value));
            form23.ShowDialog();
        }

        private void licenseInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form21 form21 = new Form21();
            form21.LoadInfo(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[1].Value));
            form21.ShowDialog();
        }
    }
}
