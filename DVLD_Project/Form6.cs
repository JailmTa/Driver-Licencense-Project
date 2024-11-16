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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            DataTable dt = clsBussnesLayer.GetAllUsersShowing();
            guna2DataGridView1.DataSource = dt;
            cbFilters.Items.Add("None");
            guna2TextBox1.Visible = false;
            cbIsActive.Visible = false;
            cbFilters.SelectedIndex = 0;
            foreach (DataColumn column in dt.Columns)
            {
                cbFilters.Items.Add(column.ColumnName);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.Text == "None")
            {
                guna2TextBox1.Visible = false;
                cbIsActive.Visible = false;
                guna2DataGridView1.DataSource = clsBussnesLayer.GetAllUsersShowing();
            }
            else if (cbFilters.Text != "IsActive")
            {
                guna2TextBox1.Visible = true;
                guna2DataGridView1.DataSource = clsBussnesLayer.GetAllUsersShowing();
                guna2TextBox1.Clear();
                cbIsActive.Visible = false;
            }
            else
            {
                guna2TextBox1.Visible = false;
                guna2DataGridView1.DataSource = clsBussnesLayer.GetAllUsersShowing();
                cbIsActive.Visible = true;
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (cbFilters.Text == "None" || cbFilters.Text == "")
            {

                guna2DataGridView1.DataSource = clsBussnesLayer.GetAllUsersShowing();
            }
            else if (cbFilters.Text == "PersonID" || cbFilters.Text == "UserID")
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
                        guna2DataGridView1.DataSource = clsBussnesLayer.FindWithFiltersU(Num, cbFilters.Text, "");
                    }
                }
            }

            else
            {
                guna2DataGridView1.DataSource = clsBussnesLayer.FindWithFiltersU(0, cbFilters.Text, guna2TextBox1.Text);
            }
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIsActive.Text != "None")
                guna2DataGridView1.DataSource = clsBussnesLayer.FindWithFiltersU(0, cbIsActive.Text, "");
            else
                guna2DataGridView1.DataSource = clsBussnesLayer.GetAllUsersShowing();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form8 form9 = new Form8();
            form9.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (clsBussnesLayer.DeleteUser(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value)) == 0)
            {
                MessageBox.Show("YOY CANT");
            }
          
           
        }

        private void changePassWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value));  
            form9.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[1].Value), Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value));
            form7.ShowDialog();
        }
    }
}
