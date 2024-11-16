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
using System.Security.Cryptography;

namespace DVLD_Project
{
    
    public partial class Form7 : Form
    {
        bool _Flag = false;
        int _ID = 0,_UsserID=0;
        public Form7()
        {
            InitializeComponent();
        }

        public Form7(int ID,int PersonID)
        {
            InitializeComponent();
            _ID= ID;
            cbFilters.Enabled = false;
            guna2TextBox1.Enabled = false;
            guna2Button3.Enabled = false;
            guna2Button4.Enabled = false;
            getInformations1.GetInfo(ID);
            _UsserID = PersonID;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            DataTable dt = clsBussnesLayer.GettAllPersons();
            foreach (DataColumn column in dt.Columns)
            {
                cbFilters.Items.Add(column.ColumnName);
            }
        }

        private string Encryption()
        {
            string Text = clsBussnesLayer.HasingPassWord(tbPassWord.Text);
           
            return Text;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (cbFilters.Enabled)
                clsBussnesLayer.AddUsers(0, _ID, tbUserName.Text, Encryption(), ckbActive.Checked);
            else
                if (tbConPassWord.Text == tbPassWord.Text)
            {
                clsBussnesLayer.UpdateUser(_UsserID, _ID, tbUserName.Text, Encryption(), ckbActive.Checked);
            }
            else
            {
                MessageBox.Show("The PassWord Not Matched ", "Error At UpDate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void getInformations1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void filterPeople1_Load(object sender, EventArgs e)
        {

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
                        dt = clsBussnesLayer.FindWithFilters(Num, cbFilters.Text, "");
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

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (clsBussnesLayer.FindWithFiltersU(_ID, "PersonID", "") == null)
            {
                tabControl1.SelectedIndex = 1;
            }
            else
            {
                tabControl1.SelectedIndex = 0;
                MessageBox.Show("You Must Add User Not Entered Before","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tbOldPassWord_Validating(object sender, CancelEventArgs e)
        {
            string PassWord = "";
            foreach (char c in tbOldPassWord.Text)
            {
                PassWord += (char)((int)c + 15);
            }
            if (clsBussnesLayer.LoginUser(tbUserName.Text, PassWord) > 0)
            {
                e.Cancel = false;
                errorProvider1.SetError(tbOldPassWord, "");
            }
            else
            {
                e.Cancel = true;
                tbOldPassWord.Focus();
                errorProvider1.SetError(tbOldPassWord, "This PassWord Is False !..");
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            bool flag = (clsBussnesLayer.FindWithFiltersU(_ID, "PersonID", "")!=null && guna2TextBox1.Enabled);
            if (flag)
            {
                e.Cancel = flag;
                MessageBox.Show("888");
            }
            else
            {

            }
        }
    }
}
