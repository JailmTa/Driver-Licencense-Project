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
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
        }

        private void Form25_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = clsBussnesLayer.GetAllInterNational();
        }

        private void showPersonalInformationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.GetInfoByDriverID(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[2].Value));
            form4.ShowDialog();
        }

        private void sHowLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form23 form23 = new Form23(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[2].Value));
            form23.ShowDialog();
        }

        private void showLicenseInformations3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form26 form23 = new Form26(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value));
            form23.ShowDialog();
        }
    }
}
