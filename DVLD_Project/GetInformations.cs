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
    public partial class GetInformations : UserControl
    {
        int _ID = 0,_DriverID=0;
        string _NetionalNo="";
        public GetInformations(int ID)
        {
            InitializeComponent();
            _ID = ID;

        }

        public GetInformations()
        {
            InitializeComponent();
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GetInformations_Load(object sender, EventArgs e)
        {
            DataTable dt = clsBussnesLayer.Find(_ID);
            if (dt != null)
            {
                
                foreach (DataRow dr in dt.Rows)
                {
                    lblPersonID.Text = dr[0].ToString();
                    _ID = Convert.ToInt32(dr[0].ToString());
                    lblNationalID.Text = dr[1].ToString();
                    _NetionalNo = dr[1].ToString();
                    lblName.Text = dr[2].ToString() + dr[3].ToString() + dr[4].ToString() + dr[5].ToString();
                    lblBirthDate.Text = dr[6].ToString();
                    lblGonder.Text = dr[7].ToString();
                    lblAddreass.Text = dr[8].ToString();
                    lblPhone.Text = dr[9].ToString();
                    lblEmail.Text = dr[10].ToString();
                    lblCountry.Text = dr[11].ToString();
                    if (dr[12]!=null)
                    pbProfile.Image = Image.FromFile(dr[12].ToString());
                }
            }
        }

        public int GetID()
        {
            return _ID;
        }
        public string GetNetionalNo()
        {
            return _NetionalNo;
        }

        public void GetInfo(int Num)
        {
            DataTable dt = clsBussnesLayer.Find(Num);
            if (dt != null)
            {
                _ID = Num;
                foreach (DataRow dr in dt.Rows)
                {
                    lblPersonID.Text = dr[0].ToString();
                    lblNationalID.Text = dr[1].ToString();
                    _NetionalNo = dr[1].ToString();
                    lblName.Text = dr[2].ToString() + dr[3].ToString() + dr[4].ToString() + dr[5].ToString();
                    lblBirthDate.Text = dr[6].ToString();
                    lblGonder.Text = dr[7].ToString();
                    lblAddreass.Text = dr[8].ToString();
                    lblPhone.Text = dr[9].ToString();
                    lblEmail.Text = dr[10].ToString();
                    lblCountry.Text = dr[11].ToString();
                    if (dr[12] != null)
                        pbProfile.Image = Image.FromFile(dr[12].ToString());
                }
            }
        }

        public void GetInfoByDriverID(int DriverID)
        {
            DataTable dt = clsBussnesLayer.GetPersonInfoByDriverID(DriverID);
            if (dt != null)
            {
              //  _ID = Num;
                foreach (DataRow dr in dt.Rows)
                {
                    lblPersonID.Text = dr[0].ToString();
                    _ID=Convert.ToInt32(lblPersonID.Text);
                    lblNationalID.Text = dr[1].ToString();
                    _NetionalNo = dr[1].ToString();
                    lblName.Text = dr[2].ToString() + dr[3].ToString() + dr[4].ToString() + dr[5].ToString();
                    lblBirthDate.Text = dr[6].ToString();
                    lblGonder.Text = dr[7].ToString();
                    lblAddreass.Text = dr[8].ToString();
                    lblPhone.Text = dr[9].ToString();
                    lblEmail.Text = dr[10].ToString();
                    lblCountry.Text = dr[11].ToString();
                    if (dr[12] != null)
                        pbProfile.Image = Image.FromFile(dr[12].ToString());
                }
            }
        }

        public int GetInfoNetionalNo(string Num)
        {
            DataTable dt = clsBussnesLayer.FindWithFilters(0, "NationalNo",Num);
            if (dt != null)
            {
               
                foreach (DataRow dr in dt.Rows)
                {
                    lblPersonID.Text = dr[0].ToString();
                    _ID = Convert.ToInt32(dr[0].ToString());
                    lblNationalID.Text = dr[1].ToString();
                    _NetionalNo = dr[1].ToString();
                    lblName.Text = dr[2].ToString() + dr[3].ToString() + dr[4].ToString() + dr[5].ToString();
                    lblBirthDate.Text = dr[6].ToString();
                    lblGonder.Text = dr[7].ToString();
                    lblAddreass.Text = dr[8].ToString();
                    lblPhone.Text = dr[9].ToString();
                    lblEmail.Text = dr[10].ToString();
                    lblCountry.Text = dr[11].ToString();
                    if (dr[12] != null)
                        pbProfile.Image = Image.FromFile(dr[12].ToString());
                    break;
                }
            }
            return _ID;
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3(_ID);
            form3.ShowDialog();
        }
    }
}
