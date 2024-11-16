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
    public partial class Form14 : Form
    {
        int _ClassID = 0;
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            DataTable dt = clsBussnesLayer.GetAllLocalLecinse();
            guna2DataGridView1.DataSource = dt;
            cbFilters.Items.Add("None");
            guna2TextBox1.Visible = false;
            cbFilters.SelectedIndex = 0;
            foreach (DataColumn column in dt.Columns)
            {
                cbFilters.Items.Add(column.ColumnName);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.ShowDialog();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (cbFilters.Text == "None" || cbFilters.Text == "")
            {

                guna2DataGridView1.DataSource = clsBussnesLayer.GetAllLocalLecinse();
            }
            else if (cbFilters.Text == "AppID_LocalDrivingLicense" || cbFilters.Text == "NetionalNo")
            {

                int Num = 0;
                if (guna2TextBox1.Text != "")
                {
                    int.TryParse(guna2TextBox1.Text, out Num);
                    if (Num == 0)
                    {
                        guna2TextBox1.Text = "";
                    }
                    else
                    {
                        guna2DataGridView1.DataSource = clsBussnesLayer.FindWithFiltersL(Num, cbFilters.Text, "");
                    }
                }
            }

            else
            {
                guna2DataGridView1.DataSource = clsBussnesLayer.FindWithFiltersL(0, cbFilters.Text, guna2TextBox1.Text);
            }
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.Text == "None")
            {
                guna2TextBox1.Visible = false;
                guna2DataGridView1.DataSource = clsBussnesLayer.GetAllLocalLecinse();
            }
            else
            {
                guna2TextBox1.Visible = true;
            }
        }

        private void changePassWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsBussnesLayer.CanselApp(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value));
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17(
                Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value.ToString()),
                guna2DataGridView1.CurrentRow.Cells[1].Value.ToString(),
                Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[5].Value.ToString()),
                guna2DataGridView1.CurrentRow.Cells[2].Value.ToString());
            form17.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void visonTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ClassID = 0;
            foreach (char c in guna2DataGridView1.CurrentRow.Cells[1].Value.ToString())
            {
                string Text = c + " ";
                int.TryParse(Text, out ClassID);
                if (ClassID > 0)
                {
                    _ClassID = ClassID;
                    break;
                }
            }
            Form16 form16 = new Form16(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value.ToString()), guna2DataGridView1.CurrentRow.Cells[1].Value.ToString(),
                Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[5].Value.ToString()), guna2DataGridView1.CurrentRow.Cells[2].Value.ToString(), 1, Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value.ToString()), _ClassID);
            form16.ShowDialog();
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            int TestsDone = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[5].Value);
            drivingTestToolStripMenuItem.Enabled = false;
            writtenTestToolStripMenuItem.Enabled = false;
            visonTestToolStripMenuItem.Enabled = false;
            contextMenuStrip2.Items[5].Enabled = false;
            contextMenuStrip2.Items[6].Enabled = false;
            if (TestsDone == 0)
            {
                visonTestToolStripMenuItem.Enabled = true;
            }
            if (TestsDone == 1)
            {
                writtenTestToolStripMenuItem.Enabled = true;
            }
            else if (TestsDone == 2)
            {

                drivingTestToolStripMenuItem.Enabled = true;
            }
            else
            {
                contextMenuStrip2.Items[5].Enabled = true;
                contextMenuStrip2.Items[6].Enabled = true;
            }
        }

        private void writtenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ClassID = 0;
            foreach (char c in guna2DataGridView1.CurrentRow.Cells[1].Value.ToString())
            {
                string Text = c + " ";
                int.TryParse(Text, out ClassID);
                if (ClassID > 0)
                {
                    _ClassID = ClassID;
                    break;
                }
            }
            Form16 form16 = new Form16(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value.ToString()), guna2DataGridView1.CurrentRow.Cells[1].Value.ToString(),
                Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[5].Value.ToString()), guna2DataGridView1.CurrentRow.Cells[2].Value.ToString(), 2, Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value.ToString()), _ClassID);
            form16.ShowDialog();
        }

        private void drivingTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ClassID = 0;
            foreach (char c in guna2DataGridView1.CurrentRow.Cells[1].Value.ToString())
            {
                string Text = c + " ";
                int.TryParse(Text, out ClassID);
                if (ClassID > 0)
                {
                    _ClassID = ClassID;
                    break;
                }
            }
            Form16 form16 = new Form16(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value.ToString()), guna2DataGridView1.CurrentRow.Cells[1].Value.ToString(),
                Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[5].Value.ToString()), guna2DataGridView1.CurrentRow.Cells[2].Value.ToString(), 3, Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value.ToString()), _ClassID);
            form16.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            int ClassID = 0;
            foreach (char c in guna2DataGridView1.CurrentRow.Cells[1].Value.ToString())
            {
                string Text = c + " ";
                int.TryParse(Text, out ClassID);
                if (ClassID > 0)
                {
                    _ClassID = ClassID;
                    break;
                }
            }
            Form22 form16 = new Form22(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value.ToString()), guna2DataGridView1.CurrentRow.Cells[1].Value.ToString(),
                Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[5].Value.ToString()), guna2DataGridView1.CurrentRow.Cells[2].Value.ToString(), Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value.ToString()), _ClassID);
            form16.ShowDialog();

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

            Form21 form21 = new Form21(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value.ToString()));
            form21.ShowDialog();
        }

        private void showPersonLicenseHisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form23 form23 = new Form23(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value.ToString()), guna2DataGridView1.CurrentRow.Cells[2].Value.ToString());
            form23.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int _Resule=clsBussnesLayer.DeleteLicense(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value.ToString()));
            if( _Resule == -1 )
            {
                MessageBox.Show("8888");
            }
        }
    }
}
