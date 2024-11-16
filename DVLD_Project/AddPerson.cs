using BussnessLayerForDVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussnessLayerForDVLD;
using DVLD_Project.Properties;
using System.IO;


namespace DVLD_Project
{
    public partial class AddPerson : UserControl
    {
        int _ID = 0;
        string _ImagePath = "", _DS = "";
        public AddPerson(string Title)
        {
            InitializeComponent();
            DataTable dt = clsBussnesLayer.GetAllCountraies();
            foreach (DataRow row in dt.Rows)
            {
                cbCountry.Items.Add(row[1]);
            }
            rbMale.Checked = true;
            dtpBirthDate.MaxDate = new DateTime(DateTime.Now.Year - 18, DateTime.Now.Month, DateTime.Now.Day);
            pbProfile.Image = Resources.icons8_male_64;
        }

        public AddPerson(string Title,int ID)
        {
            InitializeComponent();
            DataTable dt1 = clsBussnesLayer.GetAllCountraies();
            foreach (DataRow row in dt1.Rows)
            {
                cbCountry.Items.Add(row[1]);
            }
            _ID = ID;
            DataTable dt = clsBussnesLayer.Find(ID);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    lblPersonID.Text = dr[0].ToString();
                    tbNationalID.Text = dr[1].ToString();
                    tbFirstName.Text = dr[2].ToString();
                    tbSecondName.Text = dr[3].ToString();
                    tbThirdName.Text = dr[4].ToString();
                    tbLastName.Text = dr[5].ToString();
                    dtpBirthDate.Value = Convert.ToDateTime(dr[6].ToString());
                    char c = dr[7].ToString()[0];
                    if (c == 'M')
                    {
                        rbMale.Checked = true;
                    }
                    else
                    {
                        rbFemal.Checked = true;
                    }
                    tbAddreass.Text = dr[8].ToString();
                    tbPhone.Text = dr[9].ToString();
                    tbEmail.Text = dr[10].ToString();
                    cbCountry.SelectedIndex = Convert.ToInt32(dr[11].ToString()) - 1;
                    if (dr[12].ToString() != "")
                        pbProfile.Image = Image.FromFile(dr[12].ToString());
                    _DS = dr[12].ToString();
                }
            }
        }

        public AddPerson()
        {
            InitializeComponent();
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            pbProfile.Image = Resources.icons8_male_64;
        }

        private void rbFemal_CheckedChanged(object sender, EventArgs e)
        {
            pbProfile.Image = Resources.icons8_female_64;
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (tbEmail.Text.Contains('@') && tbEmail.Text.Contains(".com"))
            {
                e.Cancel = false;
                errorProvider1.SetError(tbEmail, "");
            }
            else
            {
                e.Cancel = true;
                tbEmail.Focus();
                errorProvider1.SetError(tbEmail, "This Email Is Not Suppurted");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (rbMale.Checked)
            {
                pbProfile.Image = Resources.icons8_male_64;
            }
            else
            {
                pbProfile.Image = Resources.icons8_female_64;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog(this);
            _ImagePath = openFileDialog1.FileName;
            string MainFolder = @"c:/DVLD_Project";
            string Ds = Path.Combine(MainFolder, Path.GetFileName(_ImagePath));
            _DS = Ds;
            try
            {
                File.Copy(_ImagePath, Ds, true);
                pbProfile.Image = Image.FromFile(Ds);
            }
            catch (IOException io)
            {

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            char _Gender = ' ';
            if (rbFemal.Checked)
            {
                _Gender = 'F';
            }
            else
            {
                _Gender = 'M';
            }
            if (_ID == 0)
            {
                _ID = clsBussnesLayer.AddPerson(0, tbNationalID.Text, tbFirstName.Text, tbSecondName.Text, tbThirdName.Text, tbLastName.Text, dtpBirthDate.Value, _Gender, tbAddreass.Text, tbPhone.Text, tbEmail.Text, cbCountry.SelectedIndex + 1, _DS);
                lblPersonID.Text = _ID.ToString();
            }
            else
            {
                clsBussnesLayer.UpDatePerson(_ID, tbNationalID.Text, tbFirstName.Text, tbSecondName.Text, tbThirdName.Text, tbLastName.Text, dtpBirthDate.Value, _Gender, tbAddreass.Text, tbPhone.Text, tbEmail.Text, cbCountry.SelectedIndex + 1, _DS);
            }
        }

        private void AddPerson_Load(object sender, EventArgs e)
        {

        }

        public int getID()
        {
            return _ID;
        }
    }
}
