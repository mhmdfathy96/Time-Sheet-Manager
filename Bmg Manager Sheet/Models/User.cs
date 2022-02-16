

namespace BmgManagerSheet.models
{
	public class User
	{
		public string id;
		public string name;
		public string code;
		public string email;
		public string password;
		public string gender;
		public string office;
		public User(string id,  string name,  string code,  string email,  string password, string gender, string office) {
			this.id = id;
			this.name = name;
			this.code = code;
			this.email = email;
			this.password = password;
			this.gender = gender;
			this.office = office;
		}

	}
	
}
