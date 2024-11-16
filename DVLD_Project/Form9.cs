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
    public partial class Form9 : Form
    {
        int _ID = 0;
        public Form9()
        {
            InitializeComponent();
        }

        public Form9(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            DataTable dt= clsBussnesLayer.FindUser(clsBussnesLayer.GetUserID());
            if(dt!=null)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    lblUserID.Text = dr["UserID"].ToString();
                    tbUserName.Text = dr["UserName"].ToString();
                    break;
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (tbPassWord.Text == tbConPassWord.Text)
            {
                if (_ID == 0)
                {
                    int _UserID = clsBussnesLayer.GetUserID(), _PersonID = 0;
                    DataTable dataTable = clsBussnesLayer.FindUser(_UserID);
                    if (dataTable != null)
                    {
                        foreach (DataRow dr in dataTable.Rows)
                        {
                            _PersonID = Convert.ToInt32(dr["PersonID"]);
                        }
                    }
                    string PassWord = "";
                    foreach(char c in tbPassWord.Text)
                    {
                        PassWord += (char)((int)c + 15);
                    }
                    if (MessageBox.Show("Are You Sure You Want To UpDate ?", "Comfermaing", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                    {
                        clsBussnesLayer.UpdateUser(_UserID, _PersonID, tbUserName.Text, PassWord, ckbActive.Checked);
                        MessageBox.Show("The Person Added Succeasfuly ", "Comfermaing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                }
                else
                {
                    int _PersonID = 0;
                    DataTable dataTable = clsBussnesLayer.FindUser(_ID);
                    if (dataTable != null)
                    {
                        foreach (DataRow dr in dataTable.Rows)
                        {
                            _PersonID = Convert.ToInt32(dr["PersonID"]);
                        }
                    }
                    string PassWord = "";
                    foreach (char c in tbPassWord.Text)
                    {
                        PassWord += (char)((int)c + 15);
                    }
                    if (MessageBox.Show("Are You Sure You Want To UpDate ?", "Comfermaing", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                    {
                        clsBussnesLayer.UpdateUser(_ID, _PersonID, tbUserName.Text, PassWord, ckbActive.Checked);
                        MessageBox.Show("The Person Added Succeasfuly ", "Comfermaing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("The PassWord Not Matched ","Error At UpDate",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void tbOldPassWord_Validating(object sender, CancelEventArgs e)
        {
            if(_ID == 0)
            {
               _ID= clsBussnesLayer.GetUserID();
            }
            string PassWord = "";
            foreach (char c in tbOldPassWord.Text)
            {
                PassWord += (char)((int)c + 15);
            }
            if (clsBussnesLayer.LoginUser(tbUserName.Text, PassWord)>0)
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

        private void tbOldPassWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
