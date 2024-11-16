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

namespace DVLD_Project
{
    public partial class UserInfo : UserControl
    {
        int _UserID = 0,_PersonID=0;
        public UserInfo()
        {
            InitializeComponent();
        }

        public UserInfo(int userID)
        {
            InitializeComponent();
            _UserID = userID;
            DataTable dt = clsBussnesLayer.FindUser(_UserID);
            if(dt != null ) 
            foreach (DataRow dr in dt.Rows)
            {
                lblUesrName.Text = dr["UserName"].ToString();
                lblUserID.Text = dr["UserID"].ToString();
                lblActive.Text = dr["IsActive"].ToString();
                    _PersonID = Convert.ToInt32(dr["PersonID"]);
            }
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form9 form=new Form9(_UserID);
            form.ShowDialog();
        }

        public int getPersonID()
        {
            return _PersonID;
        }
        
    }
}
