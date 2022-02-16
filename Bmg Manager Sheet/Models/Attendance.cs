
using System;
using System.Collections.Generic;
using BmgManagerSheet.Models;

namespace BmgManagerSheet.models
{
	public class Attendance
	{
		public string date;
		public string startTime;
		public string endTime;
		public bool isHoliday;
		public bool isRamadan;

		public Attendance(string date, string startTime, string endTime, bool isHoliday, bool isRamadan)
		{
			this.date = date;
			this.startTime = startTime;
			this.endTime = endTime;
			this.isHoliday = isHoliday;
			this.isRamadan = isRamadan;

		}
		public Dictionary<int, object> GetView(int regTime)
		{
			MyTools myTools = new MyTools();
			DateTime start = DateTime.Parse(startTime);
			DateTime end = DateTime.Parse(endTime);
			var mins = int.Parse(end.Subtract(start).TotalMinutes.ToString());
			int regular = regTime;
			int holiday = 0;

			if (isHoliday)
			{
				holiday = mins;
				mins = regular;
				return new Dictionary<int, object> { { 0, new AttendanceView(date, startTime, endTime, myTools.Outofmins(mins),"", myTools.Outofmins(holiday)) }, { 1, new List<int> { mins, holiday } } };
			}
			else
			{
				return new Dictionary<int, object> { { 0, new AttendanceView(date, startTime, endTime, myTools.Outofmins(mins), "", myTools.Outofmins(holiday)) }, { 1, new List<int> { mins, holiday } } };

			}

		}
	}
}
