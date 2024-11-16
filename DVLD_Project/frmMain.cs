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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form2 = new Form6();
            form2.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showUserInformationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void changePassWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();  
            form9.ShowDialog();
        }

        private void maneageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.ShowDialog();
        }

        private void maneageTestsTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.ShowDialog();
        }

        private void newLocaleLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.ShowDialog();
        }

        private void maneageApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void drivingLicenseServerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form18 form18 = new Form18();   
            form18.ShowDialog();
        }

        private void newInternationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form24 form24 = new Form24();
            form24.ShowDialog();
        }

        private void addLocalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.ShowDialog();
        }

        private void addGlobalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form25 form25 = new Form25();
            form25.ShowDialog();
        }

        private void renewLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form27 form27 = new Form27();   
            form27.ShowDialog();
        }

        private void replaceLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form28 form28 = new Form28();   
            form28.ShowDialog();
        }

        private void detiningLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form29 form29 = new Form29();   
            form29.ShowDialog();    
        }

        private void manageDetiningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form30 form30 = new Form30();   
            form30.ShowDialog();
        }

        private void relaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form31 form31 = new Form31();   
            form31.ShowDialog();
        }
    }
}
