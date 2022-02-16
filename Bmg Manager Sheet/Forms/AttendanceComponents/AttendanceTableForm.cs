using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using BmgManagerSheet.models;
using BmgManagerSheet.Models;
using Microsoft.VisualBasic;

namespace BmgManagerSheet
{
    public partial class AttendanceTableForm : Form
    {
        private static List<User> Allemps;
        private static List<string> Month;
        private Dictionary<string, object> allDataforthisMonth=new Dictionary<string, object>();
        private static string thismonth;
        private static User thisUser;
        private static AttendanceServices attendanceServices;
        private static TimeController timeController;
        private static MyTools myTools;
        public AttendanceTableForm(List<User> allemps, TimeController timeControllerr)
        {
            InitializeComponent();
            Allemps = allemps;
            timeController = timeControllerr;
            Month = new Constant().AllMonths;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tableform_Load(object sender, EventArgs e)
        {
            attendanceServices = new AttendanceServices();
            myTools = new MyTools(currentForm: this,timeControllerr:timeController);
            thisUser = Allemps[0];
            thismonth = Month[DateTime.Now.Month - 1];
            Monthcombo.SelectedIndex = DateTime.Now.Month - 1;
            ShowEmps();
            MonthDetails(0);

        }

        private void Exitbtn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Backbtn2_Click_1(object sender, EventArgs e) => myTools.Opennewform(new AttendanceControllerForm(Allemps,timeController));

        private void ShowEmps()
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            if (Allemps != null)
            {
                Empcombo.Enabled = true;
                foreach (User user in Allemps)
                {
                    comboSource.Add(user.code, user.name);
                }
                Empcombo.DataSource = new BindingSource(comboSource, null);
                Empcombo.DisplayMember = "Value";
                Empcombo.ValueMember = "Key";
                Empcombo.SelectedIndex = 0;
              //  thisCode = Allemps[0].code;
            }
        }


        private void Monthcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            thismonth = Monthcombo.SelectedItem as string;
             FetchAttendance();
            MonthDetails(0);


        }

        private void Empcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            thisUser = Allemps[Empcombo.SelectedIndex];
            FetchAttendance();
      }


        private async void DeleteMonth_Click(object sender, EventArgs e)
        {

           await myTools.Button_Click( attendanceServices.DeleteMonth(Allemps, thismonth));
            dataGridView1.Rows.Clear();
        }

        private void Totalthismonth_Click(object sender, EventArgs e)
        {
            var res = Interaction.InputBox("Please enter Ramadan's days in this Month", "How many days in Ramadan?", "0");

            if (int.TryParse(res, out _) && int.Parse(res) <= 31)
            {
                MonthDetails(int.Parse(res));
            }
            else
            {
                MessageBox.Show("NOT VALID!!");
            }
        }

        private void MonthDetails(int daysinRamadan)
        {
            var result = myTools.Totalhoursofthemonth(thismonth,daysinRamadan);
            var totalhours = result["totalHours"];
            var totaldays = result["totalDays"];
            totalthismonth.Text = $"Note:Total Regular Hours in {thismonth} = {totalhours} in {totaldays} Days";

        }

        private async void FetchAttendance() {
            var all =  await attendanceServices.GetAttendance(thisUser,thismonth);
            dataGridView1.Rows.Clear();
            foreach (AttendanceView attendance in all)
            {
                    dataGridView1.Rows.Add(attendance.date, attendance.startTime, attendance.endTime, attendance.regular, attendance.overTime, attendance.holidayHours);
            }
            


        }

        private async void Printbtn_Click(object sender, EventArgs e)
        {
            allDataforthisMonth = await myTools.Button_Click(attendanceServices.GetAttendanceforAll(Allemps, thismonth)) as Dictionary<string, object>;
            if (allDataforthisMonth.Count != 0) myTools.Opennewform(new Attendanceprintform(Allemps, allDataforthisMonth, this));
        }
    }

   
}
