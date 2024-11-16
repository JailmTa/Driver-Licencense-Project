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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = clsBussnesLayer.GettAllPersons();
            DataTable dt = clsBussnesLayer.GettAllPersons();
            cbFilters.Items.Add("None");
            cbFilters.SelectedIndex = 0;
            foreach (DataColumn column in dt.Columns)
            {
                cbFilters.Items.Add(column.ColumnName);
            }
        }

        private void editePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form2 = new Form3(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value));
            form2.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsBussnesLayer.DeletePerson(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value));
        }

        private void showInformationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value));
            form.ShowDialog();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (cbFilters.Text == "PersonID" )
            {
                int Num=0;
                if (guna2TextBox1.Text != "")
                {
                    int.TryParse(guna2TextBox1.Text, out Num);
                    if (Num == 0)
                    {
                        guna2TextBox1.Text = "";
                    }
                    else
                    {
                        guna2DataGridView1.DataSource = clsBussnesLayer.FindWithFilters(Num, cbFilters.Text, "");
                    }
                }

            }
            else if (cbFilters.Text != "None")
                guna2DataGridView1.DataSource = clsBussnesLayer.FindWithFilters(0, cbFilters.Text, guna2TextBox1.Text);
            else if (cbFilters.Text == "None" || guna2TextBox1.Text == "")
                guna2DataGridView1.DataSource = clsBussnesLayer.GettAllPersons();
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.Text == "None")
            {
                guna2TextBox1.Visible = false;
                guna2DataGridView1.DataSource = clsBussnesLayer.GettAllPersons();
            }
            else
            {
                guna2TextBox1.Visible = true;
                guna2DataGridView1.DataSource = clsBussnesLayer.GettAllPersons();
                guna2TextBox1.Clear();
            }
        }
    }
}
