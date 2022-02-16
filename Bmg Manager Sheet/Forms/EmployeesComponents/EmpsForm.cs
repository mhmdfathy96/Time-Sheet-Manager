using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BmgManagerSheet.models;

namespace BmgManagerSheet
{
    public partial class EmpsForm : Form
    {
        private readonly List<User> allEmps;
        private MyTools myTools;
        public EmpsForm(List<User> all)
        {
            InitializeComponent();
            allEmps = all;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myTools = new MyTools(currentForm: this);
            myTools.AddEmps(allEmps,EmpReport1);
        }

        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            new MyTools().Opennewform(new Main());
        }

        private void EmpReport1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
