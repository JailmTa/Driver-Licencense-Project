using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussnessLayerForDVLD;
using Microsoft.Win32;

namespace DVLD_Project
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string txt = clsBussnesLayer.HasingPassWord(tbPassWord.Text);          
            int Num = clsBussnesLayer.LoginUser(tbUserName.Text,txt);
            clsBussnesLayer.SetLogin(Num);
            if (Num>0)
            {
                if (checkBox1.Checked)
                {
                    clsBussnesLayer.SetUserNameAndPassWord(tbUserName.Text.ToString(), tbPassWord.Text.ToString());
                }
                else
                {
                    clsBussnesLayer.SetUserNameAndPassWord("","");
                }
                this.Hide();
                frmMain form = new frmMain();
                form.ShowDialog();
            }
            else
            {
                string UsersEL = "Users_Logging_DVLD_Applcation";
                if (!EventLog.SourceExists(UsersEL))
                {
                    EventLog.CreateEventSource(UsersEL,"Applcation");
                   
                }
                EventLog.WriteEntry(UsersEL, $"This Login Is Denay For UserName : {tbUserName.Text} , PassWord : {tbPassWord.Text}", EventLogEntryType.Error);
                MessageBox.Show("nnnn");
            }
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string[] strings = clsBussnesLayer.GetUserNameAndPassWord();
            if (strings!=null)
            {
                tbUserName.Text = strings[0];
                tbPassWord.Text = strings[1];
                checkBox1.Checked = true;
            }
        }
    }
}
