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
    public partial class Attendanceprintform : Form
    {
        private readonly Form currentForm;
        private static List<User> Allemps = new List<User>();
        private static Dictionary<string, object> allDataforthisMonth;
        private MyTools myTools;
        public Attendanceprintform(List<User> allEmps, Dictionary<string, object> allDataforthisMonths,Form current)
        {
            InitializeComponent();
            Allemps = allEmps;
            allDataforthisMonth = allDataforthisMonths;
            currentForm = current;
          //  AllATTT = allatt;
        }

        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Attendanceprintform_Load(object sender, EventArgs e)
        {
            myTools = new MyTools(currentForm: this);
            myTools.FetchAttendance(Allemps, allDataforthisMonth, AttendanceReport1);
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            myTools.Opennewform(currentForm);
        }
    }
}
