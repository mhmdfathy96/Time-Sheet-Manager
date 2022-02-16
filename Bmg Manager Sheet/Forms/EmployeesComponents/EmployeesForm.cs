using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BmgManagerSheet.Classes;
using BmgManagerSheet.DataBase.UserServices;
using BmgManagerSheet.models;

namespace BmgManagerSheet
{
    public partial class EmployeesForm : Form
    {
        private static List<User> Allemps;
        private static User selectedEmp;
        private readonly UserServices userServices = new UserServices();
        private readonly ComboHelper comboHelper = new ComboHelper();
        private  MyTools myTools;
        public EmployeesForm(List<User> allemps)
        {
            InitializeComponent();
            Allemps = allemps;
        }

        private void ExistingRadio_CheckedChanged(object sender, EventArgs e)
        {
            Empcombo.Enabled = true;
            ShowEmps();
            FetchBoxes();
            SwitchVisibility(true);
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            myTools = new MyTools(currentForm: this);
            ShowEmps();
            FetchBoxes();

        }
        private void ShowEmps()
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            if ( Allemps!= null)
            {
                foreach (User user in Allemps)
                {
                    comboSource.Add(user.code, user.name);
                }
                Empcombo.DataSource = new BindingSource(comboSource, null);
                Empcombo.DisplayMember = "Value";
                Empcombo.ValueMember = "Key";
                Empcombo.SelectedIndex = 0;
            }
        }

        private void AddnewRadio_CheckedChanged(object sender, EventArgs e)
        {
            Empcombo.Enabled = false;
            FetchBoxes();
            SwitchVisibility(false);
            codeBox.Text =(int.Parse(Allemps[Allemps.Count - 1].code)+1).ToString();
        }

        private void FetchBoxes() {
            if (ExistingRadio.Checked)
            {
                codeBox.Text = selectedEmp.code;
                nameBox.Text = selectedEmp.name;
                mailBox.Text = selectedEmp.email;
                PasswordBox.Text = selectedEmp.password;
                GenderCombo.SelectedIndex = (selectedEmp.gender == "Male") ? 0 : 1;
                OfficeCombo.SelectedIndex = (selectedEmp.office == "Cairo") ? 0 : 1;
            }
            else {
                codeBox.Text ="";
                nameBox.Text = "";
                mailBox.Text = "";
                PasswordBox.Text = "";
                GenderCombo.SelectedIndex = 0;
                OfficeCombo.SelectedIndex = 0;
            }
            

        }

        private void Empcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectedEmp = Allemps[Empcombo.SelectedIndex];
            FetchBoxes();
        }

        private void SwitchVisibility(bool x) {
            codeBox.Enabled = !x;
            UserEdit.Visible = x;
            Deletebtn.Visible = x;
            Addbtn.Visible = !x;
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
             myTools.Opennewform(new Main());
        }

        private async void Addbtn_Click (object sender, EventArgs e) 
        {
            var code = codeBox.Text;
            var name = nameBox.Text;
            var email = mailBox.Text;
            var password = PasswordBox.Text;
            var gender = comboHelper.GetSelectedGender(GenderCombo);
            var office = comboHelper.GetSelectedOffice(OfficeCombo);
            var user = new User("", name, code, email,password,gender, office);
            if (!int.TryParse(code, out _) || code.Length !=4 ) {
                MessageBox.Show("Code not Valid");
                return;
            }
            if (name.Trim().Length == 0)
            {
                MessageBox.Show("Please write a name");
                return;
            }
            if (password.Trim().Length == 0)
            {
                MessageBox.Show("Please write a password");
                return;
            }

            if (Allemps.FindIndex(x => x.code == code) < 0)
            {
                var ID=await myTools.Button_Click(userServices.AddNewEmp(user));
                user.id = ID;
                Allemps.Add(user);
            }
            else {
                MessageBox.Show("Code already exists");
            }
        }

        private async void UserEdit_Click(object sender, EventArgs e)
        {
            var code = codeBox.Text;
            var name = nameBox.Text;
            var email = mailBox.Text;
            var password = PasswordBox.Text;
            var gender = comboHelper.GetSelectedGender(GenderCombo);
            var office = comboHelper.GetSelectedOffice(OfficeCombo);
            var newemp = new User(selectedEmp.id,name,code,email, password,gender,office);
            if (name.Trim().Length == 0)
            {
                MessageBox.Show("Please write a name");
                return;
            }
            if (password.Trim().Length == 0)
            {
                MessageBox.Show("Please write a password");
                return;
            }
            await myTools.Button_Click( userServices.UpdateEmp(newemp));
            selectedEmp = newemp;
            Allemps[Allemps.FindIndex(x => x.id == selectedEmp.id)] = newemp;
        }

        private async void Deletebtn_Click(object sender, EventArgs e)
        {

           var isDeleted=await  myTools.Button_Click( userServices.DeleteEmp(selectedEmp));
            if (isDeleted == "true")
            {
                Allemps.Remove(selectedEmp);
                ShowEmps();
            }
        }

        private void Showbtn_Click(object sender, EventArgs e)
        {
            myTools.Opennewform(new EmployeeViewer(Allemps));
        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {
            PasswordBox.PasswordChar = PasswordBox.PasswordChar == '*'? '\0':'*';
        }

        private void TableProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            PasswordBox.Text = myTools.RandomString(8);
        }

        private void GenderLabel_Click(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OfficeLabel_Click(object sender, EventArgs e)
        {

        }

        private void ComboOffice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
