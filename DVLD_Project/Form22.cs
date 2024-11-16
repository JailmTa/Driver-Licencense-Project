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
    public partial class Form22 : Form
    {
        string _ClassName = "", _NetionalNo = "";
        int _AppID = 0, _TestsDone = 0, _DL = 0, _ClassID = 0;

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            clsBussnesLayer.IssueLicense(0,_AppID,_ClassID,DateTime.Now,new DateTime(DateTime.Now.Year+10,DateTime.Now.Month,DateTime.Now.Day),guna2TextBox1.Text,20,true);
        }

        public Form22()
        {
            InitializeComponent();
        }
        public Form22(int AppID, string ClassName, int TestsDone, string NetionalNo, int DL, int ClassID)
        {
            InitializeComponent();
            _AppID = AppID;
            _ClassName = ClassName;
            _TestsDone = TestsDone;
            _NetionalNo = NetionalNo;
            _DL = DL;
            _ClassID = ClassID;
         

        }
        private void Form22_Load(object sender, EventArgs e)
        {
            getApplcationBisicInformations1.GetInfo(_AppID);
            getAppInfo1.LoadInformations(_AppID, _ClassName, _TestsDone);
        }
    }
}
