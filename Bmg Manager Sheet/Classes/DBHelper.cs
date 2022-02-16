using System;
using System.Collections.Generic;
using BmgManagerSheet.models;
using Google.Cloud.Firestore;

namespace BmgManagerSheet.Classes
{
    class DBHelper:MyTools
    {
        public List<dynamic> GetAttendanceDocument(Attendance attendance,bool isSigned) {
			Dictionary<string, object> attend;
			if ((attendance.startTime == "dayOff" || attendance.startTime == "Sickness" || attendance.startTime == "Annual Vacation" || attendance.startTime == "Official Holiday" || attendance.startTime == "workFromHome") && !isSigned) {
				attend = new Dictionary<string, object>
					{
						{ "startTime", attendance.startTime},
						{ "endTime", attendance.endTime},
						{ "isHoliday",attendance.isHoliday.ToString()},
						{ "isRamadan",attendance.isRamadan.ToString()},
					};
				return  new List<dynamic> {0,attend};
			} else if ((attendance.startTime == "dayOff" || attendance.startTime == "Sickness" || attendance.startTime == "Annual Vacation" || attendance.startTime == "Official Holiday" || attendance.startTime == "workFromHome") && isSigned)
			{
				attend = new Dictionary<string, object>
					{
						{ "startTime", attendance.startTime},
						{ "endTime", attendance.endTime},
						{ "isHoliday",attendance.isHoliday.ToString()},
						{ "isRamadan",attendance.isRamadan.ToString()},
					};
				return new List<dynamic> { 1, attend };
			}
			else if (isSigned && (attendance.endTime == null))
			{
				attend = new Dictionary<string, object>
					{
						{ "startTime", attendance.startTime},
						{ "isHoliday",attendance.isHoliday.ToString()},
						{ "isRamadan",attendance.isRamadan.ToString()},
						};
				return new List<dynamic> { 1, attend };
			}
			else if (!isSigned && (attendance.endTime == null))
			{

				attend = new Dictionary<string, object>
					{
						{ "startTime", attendance.startTime},
						{ "endTime", ""},
						{ "isHoliday",attendance.isHoliday.ToString()},
						{ "isRamadan",attendance.isRamadan.ToString()},
					};
				return new List<dynamic> { 0, attend };
			}
			else
			{
				attend = new Dictionary<string, object>
					{
						{ "endTime", attendance.endTime},
						{ "isHoliday",attendance.isHoliday.ToString()},
						{ "isRamadan",attendance.isRamadan.ToString()},
					};
				return new List<dynamic> { 1, attend }; ;
			}


		}

		public List<dynamic> GetAttendanceView(DocumentSnapshot snapShot, User user) {
			AttendanceView attendanceView = null;
			int totalTotal=0;
			int totalHoliday = 0;
			bool isRamadan = false;
			int regularInt = 0;
			string regularString = "";
			Dictionary<string, object> documentDictionary = snapShot.ToDictionary();
			if (documentDictionary.ContainsKey("isRamadan")) {
				isRamadan = Boolean.Parse(documentDictionary["isRamadan"] as string);
				regularInt = RegularTime(user, isRamadan);
				regularString = Outofmins(regularInt);
				}
			if (documentDictionary["startTime"] as string == "workFromHome")
			{
				DateTime start = DateTime.Parse("00:00");
				DateTime end = DateTime.Parse(documentDictionary["endTime"] as string);
				var mins = int.Parse(end.Subtract(start).TotalMinutes.ToString());
				string time = Outofmins(mins);
				var isHoliday = Boolean.Parse(documentDictionary["isHoliday"] as string);
				
				attendanceView = new AttendanceView(snapShot.Id, "Work", "From Home", isHoliday ? regularString : time, "", isHoliday ? time : "00:00");
				totalTotal = isHoliday ? regularInt : mins;
				totalHoliday = isHoliday ? mins : 0;
			}
			else if (documentDictionary["startTime"] as string == "dayOff")
			{
				attendanceView = new AttendanceView(snapShot.Id, "Day Off", "Day Off", "00:00", "", "00:00");
			}
			else if (documentDictionary["startTime"] as string == "Annual Vacation" || documentDictionary["startTime"] as string == "Sickness" || documentDictionary["startTime"] as string == "Official Holiday")
			{
				var title = documentDictionary["startTime"] as string;
				attendanceView = new AttendanceView(snapShot.Id, title, title, regularString, "", "00:00");
				totalTotal = regularInt;
			}
			else if (documentDictionary["endTime"] as string != "")
			{
				var isHoliday = Boolean.Parse(documentDictionary["isHoliday"] as string);
				var result = new Attendance(snapShot.Id, documentDictionary["startTime"] as string, documentDictionary["endTime"] as string, isHoliday, isRamadan).GetView(regularInt);
				attendanceView = result[0] as AttendanceView;
				List<int> nums = result[1] as List<int>;
				totalTotal = nums[0];
				totalHoliday = nums[1];
			}
			else if (documentDictionary["endTime"] as string == "")
			{
				attendanceView = new AttendanceView(snapShot.Id, documentDictionary["startTime"] as string, "", "", "", "");
				isRamadan = Boolean.Parse(documentDictionary["isRamadan"] as string);
			}
			return new List<dynamic>{ attendanceView, totalTotal,totalHoliday, isRamadan};
		}



	}
}
