using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BmgManagerSheet.models;

namespace BmgManagerSheet
{
    public partial class EmployeeViewer : Form
    {
        private static List<User> Allemps;
        private MyTools myTools;
        public EmployeeViewer(List<User> allemps)
        {
            InitializeComponent();
            Allemps = allemps;
        }

        private void Backbtn2_Click(object sender, EventArgs e)
        {
            myTools.Opennewform(new EmployeesForm(Allemps));
        }

        private void EmployeeViewer_Load(object sender, EventArgs e)
        {
            myTools = new MyTools(currentForm: this);
            FetchEmployees();
        }
        private void FetchEmployees()
        {
            EmpDGV.Rows.Clear();
            foreach (User user in Allemps)
            {
                EmpDGV.Rows.Add(user.name,user.code,user.email,user.gender,user.office);          
            }


        }

        private void EmpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
