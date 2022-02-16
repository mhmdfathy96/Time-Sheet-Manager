using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BmgManagerSheet.DataBase.TimeControllerServices;
using BmgManagerSheet.DataBase.UserServices;
using BmgManagerSheet.Forms.ControllerComponents;
using BmgManagerSheet.models;
using BmgManagerSheet.Models;

namespace BmgManagerSheet
{
    public partial class Main : Form
    {
        private List<User> allEmps;
        private static AttendanceServices attendanceServices;
        private readonly TimeControllerServices timeControllerServices = new TimeControllerServices();
        private readonly UserServices userServices = new UserServices();
        private static TimeController timeController;
        private static MyTools myTools;
        private static Dictionary<string, object> allDataforthisMonth = new Dictionary<string, object>();

        public Main()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (allEmps != null && allEmps.Count !=0 )
            {

                if (myTools.CheckPassword())
                {
                    myTools.Opennewform(new EmployeesForm(allEmps));
                }
                else {
                    MessageBox.Show("Wrong Password");
                }
                
            }
            else
            {
                MessageBox.Show("Check your internet and Try Again");
            }
        }

        private async void Main_Load(object sender, EventArgs e)
        {
           // attendanceServices = new AttendanceServices(timeController: timeController);
            myTools = new MyTools(currentForm: this);
            await GetEmp();

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void Tsbtn_Click(object sender, EventArgs e)
        {
            string thismonth = DateTime.Now.ToString("MMMM");
            allDataforthisMonth = await myTools.Button_Click(attendanceServices.GetAttendanceforAll(allEmps, thismonth)) as Dictionary<string,object>;
            if (allDataforthisMonth.Count != 0) myTools.Opennewform(new Attendanceprintform(allEmps, allDataforthisMonth, this));
         }

        private void Changebtn_Click(object sender, EventArgs e)
        {
                if (myTools.CheckPassword())
                {
                myTools.Opennewform(new AttendanceControllerForm(allEmps,timeController));
                }
                else {
                    MessageBox.Show("Wrong Password");
                }
        }

        private async void Refbtn_Click(object sender, EventArgs e)
        {

            await GetEmp();
        }

        private async Task GetEmp() {
            allEmps =await myTools.Button_Click(userServices.FetchUsers()) as List<User>;
            timeController = await myTools.Button_Click(timeControllerServices.GetSettings()) as TimeController;
            attendanceServices = new AttendanceServices();
            myTools = new MyTools(currentForm: this, timeControllerr: timeController);
            if (allEmps.Count == 0 && AttendanceBDBtn.Enabled)
            {
                SwitchBtns();
            }
            else if (allEmps.Count != 0 && !AttendanceBDBtn.Enabled) {
                SwitchBtns();
            }
            
        }

        private void AttendanceBDBtn_Click(object sender, EventArgs e)
        {
            myTools.Opennewform(new Attendancebyday(allEmps,this,timeController));
        }

        private void MainProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void ControllerBtn_Click(object sender, EventArgs e)
        {
            if (myTools.CheckPassword())
            {
                myTools.Opennewform(new ControllerForm(timeController));
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }
        }

        private void SwitchBtns() {
            AttendanceBDBtn.Enabled = !AttendanceBDBtn.Enabled;
            Changebtn.Enabled = !Changebtn.Enabled;
            Tsbtn.Enabled = !Tsbtn.Enabled;
            AllEmpsbtn.Enabled = !AllEmpsbtn.Enabled;
            ControllerBtn.Enabled = !ControllerBtn.Enabled;
        }
    }
}
