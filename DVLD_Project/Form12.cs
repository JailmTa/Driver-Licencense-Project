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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource=clsBussnesLayer.GetAllTestTypes();
        }

        private void upDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value),
                guna2DataGridView1.CurrentRow.Cells[1].Value.ToString(),
                guna2DataGridView1.CurrentRow.Cells[2].Value.ToString(),
                Convert.ToDouble(guna2DataGridView1.CurrentRow.Cells[3].Value.ToString())); 
            form13.ShowDialog();
        }
    }
}
