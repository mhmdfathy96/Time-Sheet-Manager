using System;
using System.Windows.Forms;
using System.Collections.Generic;
using BmgManagerSheet.models;
using System.Threading.Tasks;
using System.Data;
using Microsoft.VisualBasic;
using Google.Cloud.Firestore;
using BmgManagerSheet.DB;
using BmgManagerSheet.Forms.EmployeesComponents;
using BmgManagerSheet.Forms.AttendanceReportComponents;
using BmgManagerSheet.DataSet;
using System.Linq;
using BmgManagerSheet.DataBase.UserServices;
using BmgManagerSheet.Models;

namespace BmgManagerSheet
{
	class MyTools:Json
    {
		private  Form currentForm;
		public static TimeController timeController;
		public MyTools(Form currentForm=null,TimeController timeControllerr=null) {
			if(currentForm != null) this.currentForm = currentForm;
			if (timeControllerr != null) timeController = timeControllerr;
		}


		public async Task<dynamic> Button_Click(Task<dynamic> task)
		{
			ProgressBar progressBar =currentForm.Controls.OfType<ProgressBar>().FirstOrDefault();
			progressBar.Show();
			currentForm.Enabled = false;
			var dynamicObject = await task;
			currentForm.Enabled = true;
			progressBar.Value = 100;
			progressBar.Hide();
			return dynamicObject;
		}

		public void Opennewform(Form newform) {
			currentForm.Hide();
			var form2 = newform;
			form2.Closed += (s, args) => currentForm.Close();
			form2.Show();


		}

		public void Switchbtn(Button btn)
		{
			if (btn.Text == "Start")
			{
				btn.Text = "End";
			}
			else {
				btn.Text = "Start";
			}
		}

		public string Outofmins(int mins)
		{
			if (mins <= 540)
			{

			}
			int hrs = mins / 60;
			int minutes = mins % 60;
			string hr;
			string min;
			if (hrs.ToString().Length == 1)
			{
				hr = $"0{hrs}";
			}
			else
			{
				hr = hrs.ToString();
			}
			if (minutes.ToString().Length == 1)
			{
				min = $"0{minutes}";
			}
			else
			{
				min = minutes.ToString();
			}
			return $"{hr}:{min}";
		}

		public Dictionary<string, int> Totalhoursofthemonth(string month, int daysinRamadan) {
			int totalhours = 0;
			int totaldays = 0;
			//var thismonth = DateTime.Now.Month;
			var thismonth = Getmonth(month);
			var alldays = DateTime.DaysInMonth(DateTime.Now.Year, thismonth);
			for (int x = 1; x <= alldays; x++) {
				var dat = DateTime.Parse($"{thismonth}/{x}").DayOfWeek.ToString();
				if (!dat.StartsWith("S")) {
					totalhours += 9;
					totaldays += 1;
				}
			}
			if (daysinRamadan != 0 && daysinRamadan <= alldays) totalhours -= daysinRamadan;
			return new Dictionary<string, int> { { "totalHours", totalhours }, { "totalDays", totaldays } };
		}

		public int Getmonth(string name) {
			Dictionary<string, int> AllMonth = new Dictionary<string, int> { { "january", 1 }, { "february", 2 }, { "march", 3 }, { "april", 4 }, { "may", 5 }, { "june", 6 }, { "july", 7 }, { "august", 8 }, { "september", 9 }, { "october", 10 }, { "november", 11 }, { "december", 12 }, };
			return AllMonth[name.ToLower()];
		}
		public int GetNumber(string val) {
			string result = "";
			for (int x = 0; x < val.Length; x++) {
				if (Char.IsDigit(val[x])) result += val[x];
			}
			return int.Parse(result);
		}

		public void AddEmps(List<User> allUsers, EmpReport empReport) {
			DataSet1 ds = new DataSet1();
			if (allUsers != null) {
				foreach (User user in allUsers)
				{
					ds.Tables["employees_table"].Rows.Add(user.code, user.name, user.email);
				}
				empReport.SetDataSource(ds);
			}

		}

		public void FetchAttendance(List<User> allUsers, Dictionary<string, object> allDataforthisMonth, AttendanceReport attendanceReport)
		{
			DataSet1 ds = new DataSet1();

			if (allUsers != null && allUsers.Count != 0)
			{
				ds.Clear();
				foreach (User thisuser in allUsers)
				{
					List<AttendanceView> allforthisuser = allDataforthisMonth[thisuser.code] as List<AttendanceView>;
					if (allforthisuser != null && allforthisuser.Count != 0) {
						string thismonth = allDataforthisMonth["month"] as string;
						foreach (AttendanceView attendanceView in allforthisuser)
						{
							ds.attendance_table.Rows.Add(thisuser.name, thismonth, attendanceView.date, attendanceView.startTime, attendanceView.endTime, attendanceView.regular, attendanceView.overTime, attendanceView.holidayHours);
						}
					}


					attendanceReport.SetDataSource(ds);


				}
			}

		}

		public bool CheckPassword() {

			if (Interaction.InputBox("Please enter Admin password", "", "") == "0412") {
				return true;
			}
			return false;
		}

		private static readonly Random random = new Random();
		public string RandomString(int length)
		{
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			return new string(Enumerable.Repeat(chars, length)
			  .Select(s => s[random.Next(s.Length)]).ToArray());
		}

		public int RegularTime(User user,bool isRamadan) {
			return (user.office == "Mansoura") ? (user.gender == "Male") ? isRamadan ? int.Parse(timeController.RamMM) * 60 : int.Parse(timeController.RegMM) * 60 :
																									isRamadan ? int.Parse(timeController.RamMF) * 60 : int.Parse(timeController.RegMF) * 60 :
																		  (user.gender == "Male") ? isRamadan ? int.Parse(timeController.RamCM) * 60 : int.Parse(timeController.RegCM) * 60 :
																									isRamadan ? int.Parse(timeController.RamCF) * 60 : int.Parse(timeController.RegCF) * 60;
		}

	}
}
