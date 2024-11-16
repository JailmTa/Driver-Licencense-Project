using BussnessLayerForDVLD;
using Guna.UI2.WinForms;
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
    public partial class FilterPeople : UserControl
    {
        int _ID = 0;
        public FilterPeople()
        {
            InitializeComponent();
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
           
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
                        dt = clsBussnesLayer.FindWithFilters(Num, "", "");
                        foreach (DataRow row in dt.Rows)
                        {
                            _ID = Convert.ToInt32(row[0]);
                            break;
                        }

                    }
                }

            }
            else if (cbFilters.Text != "None")
            {
                dt = clsBussnesLayer.FindWithFilters(0, cbFilters.Text, guna2TextBox1.Text);
                foreach (DataRow row in dt.Rows)
                {
                    _ID = Convert.ToInt32(row[0]);
                    break;
                }
            }
            else if (cbFilters.Text == "None" || guna2TextBox1.Text == "")
            {
                dt = clsBussnesLayer.GettAllPersons();
                foreach (DataRow row in dt.Rows)
                {
                    _ID = Convert.ToInt32(row[0]);
                    break;
                }
            }
        }

        public int getID()
        {
            return _ID;
        }

        private void FilterPeople_Load(object sender, EventArgs e)
        {
            DataTable dt = clsBussnesLayer.GettAllPersons();
            foreach (DataColumn column in dt.Columns)
            {
                cbFilters.Items.Add(column.ColumnName);
            }
        }
    }
}
