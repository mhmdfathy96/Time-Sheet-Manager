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
using BmgManagerSheet.Models;

namespace BmgManagerSheet
{

    
    public partial class Attendancebyday : Form
    {
        private readonly Form currentForm;
        private static List<User> Allemps;
        private readonly AttendanceServices attendanceServices = new AttendanceServices();
        private static MyTools myTools;
        private static TimeController timeController;
        public Attendancebyday(List<User> allemps,Form current,TimeController timeControllerr)
        {
            InitializeComponent();
            Allemps = allemps;
            currentForm = current;
            timeController = timeControllerr;
        }

        private void Backbtn2_Click(object sender, EventArgs e)
        {
            //  new MyTools().Opennewform(new AttendanceControllerForm(Allemps),this);
            myTools.Opennewform(currentForm);
        }

        private async void Attendancebyday_Load(object sender, EventArgs e)
        {
            myTools = new MyTools(currentForm:this,timeControllerr:timeController);
            await FetchAttendance();

        }

        private async Task<dynamic> FetchAttendance() {
            Dictionary<string, object> all =await myTools.Button_Click(attendanceServices.GetAttendancebyDay(Allemps, DatePicker.Value)) as Dictionary<string, object>;
            AttendanceBDGV.Rows.Clear();
            if (all.Count != 0) {
                foreach (User user in Allemps)
                {
                    if (all.ContainsKey(user.code)) {
                        AttendanceView attendance = all[user.code] as AttendanceView;
                        AttendanceBDGV.Rows.Add(user.name, attendance.startTime, attendance.endTime, attendance.regular, attendance.overTime, attendance.holidayHours);
                      }
                }
            }
            return "";
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private async void GetThisDay_Click(object sender, EventArgs e)
        {
            await FetchAttendance();
        }
    }
}
