using System;
using System.Collections.Generic;
using Google.Cloud.Firestore;
using System.Windows.Forms;
using BmgManagerSheet.models;
using System.Linq;
using BmgManagerSheet.Classes;
using System.Threading.Tasks;
using BmgManagerSheet.Models;

namespace BmgManagerSheet
{
	class AttendanceServices : MyTools
	{
		public static FirestoreDb db;
		public static DBHelper dbHelper=new DBHelper();

		public AttendanceServices() {
			StartFireStore();
			db = FirestoreDb.Create("bmgtimesheet");
		}
		public void StartFireStore() {
			string path = AppDomain.CurrentDomain.BaseDirectory + @"bmgtimesheet-firebase-adminsdk-sjtu6-bd0c9f674a.json";
			Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
		}
		public async Task<dynamic> StartLeave(string userCode, Attendance attendance)
		{

			try
			{
				DocumentReference docRef = db.Collection("Attendance").Document(attendance.date.Split(' ').Last<string>()).Collection(userCode).Document(attendance.date);
				bool isSigned = await Checkifalreadysigned(attendance, userCode);
				var result=dbHelper.GetAttendanceDocument(attendance, isSigned);
				if (result[0] == 0)
				{
					await docRef.SetAsync(result[1]);
				}
				else {
					await docRef.UpdateAsync(result[1]);
				}

			}
			catch
			{
				//MessageBox.Show(e.Message);
			}
			return "";
		}

		public async Task<bool> Checkifalreadysigned(Attendance attendance, string userCode) {
			bool issigned = false;
			try
			{
				Query usersRef = db.Collection("Attendance").Document(DateTime.Now.ToString("MMMM")).Collection(userCode);
				QuerySnapshot snapshot = await usersRef.GetSnapshotAsync();
				if (snapshot != null)
				{
					foreach (DocumentSnapshot document in snapshot.Documents)
					{
						Dictionary<string, object> documentDictionary = document.ToDictionary();
						if (document.Id == attendance.date) {
							issigned = true;
						}
					}
				} return issigned;
			}

			catch
			{
				return issigned;
			}
		}

		public async Task<dynamic> EditAttendance(List<string> userCode, List<Attendance> Allattendance) {
			try
			{
				for (int x = 0; x < Allattendance.Count; x++) {

					await StartLeave(userCode[x], Allattendance[x]);
				}
				MessageBox.Show("Your data has been modified");
				return "true";
			}
			catch {
				MessageBox.Show("Something wrong,check your Connection");
				return "false";
			}
		}

		

		public async Task<List<AttendanceView>> GetAttendance(User user, string month)
		{
			List<AttendanceView> all = new List<AttendanceView>();
			int totalTotal = 0;
			int totalOver = 0;
			int totalHoliday = 0;
			int totalTillNow = 0;
			bool isRamadan = false;
			try
			{
				Query usersRef = db.Collection("Attendance").Document(month).Collection(user.code);
				QuerySnapshot snapshot = await usersRef.GetSnapshotAsync();
				if (snapshot != null)
				{
					foreach (DocumentSnapshot document in snapshot.Documents)
					{
						List<dynamic> attendance=dbHelper.GetAttendanceView(document,user);
						AttendanceView attendanceView = attendance[0];
						all.Add(attendanceView);
						totalTotal += attendance[1];
						totalHoliday += attendance[2];
						isRamadan= attendance[3];
						if (!attendanceView.date.StartsWith("S")) {
							totalTillNow += RegularTime(user, isRamadan);
						}

					}
					if (all.Count != 0) {

						all = all.OrderBy(x => GetNumber(x.date)).ToList(); }
					if (totalTotal > totalTillNow)
					{
						totalOver = totalTotal - totalTillNow;
						totalTotal = totalTillNow;
					}
					var final = new AttendanceView("Total in the Month", "", "", Outofmins(totalTotal), Outofmins(totalOver), Outofmins(totalHoliday));
					var totaltillNowRow=new AttendanceView("Gross Hours", "", "", (totalTillNow/60).ToString()+" Hr", "", "");
					all.Add(final);
					all.Add(totaltillNowRow);
					return all;
				}
				else {
					return all ;
				}
			}
			catch(Exception e)
			{
				MessageBox.Show(e.Message);
				return all;
			}

		}

		public async Task<dynamic> GetAttendanceforAll(List<User> allusers, string month) {


			Dictionary<string, object> allData = new Dictionary<string, object>();
			try
			{
				allData.Add("month", (month + " " + DateTime.Now.ToString("yyyy")));
				foreach (User thisuser in allusers) {
					List<AttendanceView> userattendance = await GetAttendance(thisuser, month);
					allData.Add(thisuser.code, userattendance);
				}
				return allData;

			}
			catch (Exception e) {
				MessageBox.Show(e.Message);
				return allData;
			}
		}

		public async Task<dynamic> GetAttendancebyDay(List<User> allusers, DateTime dateTime)
		{
			Dictionary<string, object> all = new Dictionary<string, object>();
			var month = dateTime.ToString("MMMM");
			var day = dateTime.ToString("dddd, dd MMMM");
			try
			{
				foreach (User user in allusers) {
					DocumentReference docRef = db.Collection("Attendance").Document(month).Collection(user.code).Document(day);
					DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
					if (snapshot != null && snapshot.Exists)
					{
						AttendanceView Attendanceview =dbHelper.GetAttendanceView(snapshot,user)[0];
						all.Add(user.code, Attendanceview);
					}
				}
				return all;

			}
			catch(Exception e)
			{
				MessageBox.Show(e.Message);
				//MessageBox.Show("Something wrong,check your Connection");
				return all;
			}

		}
		public async Task<dynamic> DeleteMonth(List<User> allEmp, string month)
		{
			//Dialog
			//DialogResult dialogResult = MessageBox.Show($"Are you sure to delete all data for {month}?", "", MessageBoxButtons.YesNo);
			if (CheckPassword())
			{
				try
				{
					//db = FirestoreDb.Create("bmgtimesheet");
					foreach (User user in allEmp)
					{
						Query usersRef = db.Collection("Attendance").Document(month).Collection(user.code);
						QuerySnapshot snapshot = await usersRef.GetSnapshotAsync();
						if (snapshot != null)
						{
							foreach (DocumentSnapshot document in snapshot.Documents)
							{
								await document.Reference.DeleteAsync();
							}
						}
					}
					MessageBox.Show($"Data has been deleted for {month}");
				}
				catch
				{
					MessageBox.Show("Something wrong,check your Connection");
				}
			}
			else {
				MessageBox.Show("Wrong Password");
			}
			return "";
		}

		public async Task<dynamic> DeleteDay(List<User> users,DateTime dateTime) {
			var month = dateTime.ToString("MMMM");
			var day = dateTime.ToString("dddd, dd MMMM");
			try
			{
				foreach (User user in users)
				{
					DocumentReference documentReference = db.Collection("Attendance").Document(month).Collection(user.code).Document(day);
					if (documentReference != null)
					{
						await documentReference.DeleteAsync();
					}

				}
				MessageBox.Show("Day has been Deleted");
				return true;
			}
			catch (Exception e) {
				MessageBox.Show(e.Message);
				return false;
			}
			

		}

		
		}
		
	}
