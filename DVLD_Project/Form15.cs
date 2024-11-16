using BussnessLayerForDVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class Form15 : Form
    {
        int _ID = 0;
        public Form15()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (cbFilters.Text == "PersonID")
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
                        dt = clsBussnesLayer.FindWithFilters(Num, "PersonID", "");
                        if (dt != null)
                            foreach (DataRow row in dt.Rows)
                            {
                                _ID = Convert.ToInt32(row[0]);
                                break;
                            }

                    }
                }

            }
            else
            {
                dt = clsBussnesLayer.FindWithFilters(0, cbFilters.Text, guna2TextBox1.Text);
                if (dt != null)
                    foreach (DataRow row in dt.Rows)
                    {
                        _ID = Convert.ToInt32(row[0]);
                        break;
                    }
            }

            getInformations1.GetInfo(_ID);
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            DataTable dt = clsBussnesLayer.GettAllPersons();
            foreach (DataColumn column in dt.Columns)
            {
                cbFilters.Items.Add(column.ColumnName);
            }
            dt.Clear();
            dt = clsBussnesLayer.GetAllClassesName();
            foreach (DataRow column in dt.Rows)
            {
                cbClassesName.Items.Add(column[1]);
            }
            lblDate.Text = DateTime.Now.ToString();
            lblFees.Text = "20";
            dt.Clear();
            dt = clsBussnesLayer.FindUser(clsBussnesLayer.GetUserID());
            if (dt != null)
                foreach (DataRow dr in dt.Rows)
                {
                    lblCreateBy.Text = dr["UserName"].ToString();

                }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            bool flag = (clsBussnesLayer.FindWithFiltersL(_ID, "PersonID", "") != null);
            if (flag)
            {
                e.Cancel = flag;
                MessageBox.Show("888");
            }
            else
            {

            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (clsBussnesLayer.CheckForAddLecines(getInformations1.GetNetionalNo(), cbClassesName.Text))
            {
              
                int _D = clsBussnesLayer.AddDrivingL(0, cbClassesName.SelectedIndex + 1, getInformations1.GetID(), DateTime.Now, 1, 1, DateTime.Now, 20f, clsBussnesLayer.GetUserID());
                lblAppID.Text = _D.ToString();
            }
            else
            {
                MessageBox.Show("You Can\'t Add !..","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


    }
}
