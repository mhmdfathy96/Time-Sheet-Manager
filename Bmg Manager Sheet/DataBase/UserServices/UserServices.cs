using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BmgManagerSheet.models;
using Google.Cloud.Firestore;

namespace BmgManagerSheet.DataBase.UserServices
{
	 class UserServices : AttendanceServices
	{

		public async Task<dynamic> AddNewEmp(User user)
		{
			try
			{
				object userJson = UsertoJson(user);
				DocumentReference empdetails = await db.Collection("users").AddAsync(userJson);
				MessageBox.Show($"{user.name} has been Added");
				return empdetails.Id;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				MessageBox.Show("Something wrong,check your Connection");
				return "";
			}

		}
		public async Task<dynamic> DeleteEmp(User emp)
		{
			List<string> allmonths = new Constant().AllMonths;
			if (CheckPassword())
			{
				try
				{
					await db.Collection("users").Document(emp.id).DeleteAsync();
					foreach (string x in allmonths)
					{
						Query usersRef = db.Collection("Attendance").Document(x).Collection(emp.code);
						QuerySnapshot snapshot = await usersRef.GetSnapshotAsync();
						if (snapshot != null && snapshot.Count != 0)
						{
							foreach (DocumentSnapshot document in snapshot.Documents)
							{
								await document.Reference.DeleteAsync();
							}
						}
					}

					MessageBox.Show($"{emp.name} has been Removed");
					return "true";
				}
				catch
				{
					MessageBox.Show("Something wrong,check your Connection");
					return "false";
				}
			}
			else
			{
				MessageBox.Show("Wrong Password");
				return "false";
			}
		}

		public async Task<dynamic> UpdateEmp(User user)
		{
			try
			{
				var userDocument = UsertoJson(user);
				DocumentReference docRef = db.Collection("users").Document(user.id);
				await docRef.UpdateAsync(userDocument);
				MessageBox.Show($"{user.name} has been Updated");
			}
			catch
			{

				MessageBox.Show("Something wrong,check your Connection");
			}
			return "";
		}

		public async Task<dynamic> FetchUsers()
		{
			List<User> allUsers = new List<User>();
			try
			{
				Query usersRef = db.Collection("users");
				QuerySnapshot snapshot = await usersRef.GetSnapshotAsync();

				if (snapshot != null)
				{
					foreach (DocumentSnapshot document in snapshot.Documents)
					{
						allUsers.Add(UserfromJson(document));
					}
					allUsers.Sort((x, y) => string.Compare(x.code, y.code));
					return allUsers;

				}
				else
				{
					MessageBox.Show("Something wrong,check your Connection and REFRESH");
					return allUsers;
				}
			}
			catch
			{

				//MessageBox.Show(e.Message);
				MessageBox.Show("Something wrong,check your Connection and REFRESH");
				return allUsers;
			}


		}

		public async Task<dynamic> GetPassword() {
			string password = "";
			try
			{
				CollectionReference adminRef = db.Collection("admin");
				QuerySnapshot snapshot = await adminRef.GetSnapshotAsync();
				if (snapshot != null)
				{
					foreach (DocumentSnapshot document in snapshot.Documents)
					{
						if (document.ContainsField("adminPassword")) password= document.ToDictionary()["adminPassword"] as string;
					}

				}
				else
				{
					MessageBox.Show("Something wrong,check your Connection");
				}
			}
			catch(Exception e) {
				MessageBox.Show(e.Message);
			}
			return password;
		}
	}
}
