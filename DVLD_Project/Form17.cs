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

namespace DVLD_Project
{
    public partial class Form17 : Form
    {
        string _NetionalNo = "", _ClassName="";
        int _AppID = 0, _TestsDone=0;
        Guna2DataGridView _dt=new Guna2DataGridView();
        public Form17()
        {
            InitializeComponent();
        }

        public Form17(int AppID,string ClassName,int TestsDone,string NetionalNo)
        {
            InitializeComponent();
            _AppID = AppID;
            _ClassName = ClassName;
            _TestsDone = TestsDone;
            _NetionalNo=NetionalNo;
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            getInformations1.GetInfoNetionalNo(_NetionalNo);
            getAppInfo1.LoadInformations(_AppID,_ClassName,_TestsDone);
        }
    }
}
