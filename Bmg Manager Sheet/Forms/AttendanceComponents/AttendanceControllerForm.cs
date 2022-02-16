using System;
using System.Windows.Forms;
using BmgManagerSheet.models;
using System.Collections.Generic;
using BmgManagerSheet.Models;

namespace BmgManagerSheet
{
    public partial class AttendanceControllerForm : Form
    {
        private static List<User> Allemps;
        private Boolean isHoliday = false;
        private Boolean isRamadan = false;
        private static string mDate;
        private static string mTime;
        private readonly AttendanceServices attendanceServices=new AttendanceServices();
        private static TimeController timeController;
        private  MyTools myTools;
        public AttendanceControllerForm(List<User> AllEmps,TimeController timeControllerr)
        {
            InitializeComponent();
            Allemps = AllEmps;
            timeController = timeControllerr;
            
        }



        private void Button1_Click(object sender, EventArgs e) {
            myTools.Opennewform(new Main());
        }

        private async void Startendbtn_Click(object sender, EventArgs e)
        {
            List<Attendance> all = new List<Attendance>();
            List<string> allCode = new List<string>();

            bool isStart = (startendbtn.Text == "Start");
            if (allRadio.Checked)
            {
                DialogResult dialogResult = MessageBox.Show($"Are you sure to edit all these data?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    all.Clear();
                    allCode.Clear();
                    if (startendbtn.Text == "Start" || startendbtn.Text == "End")
                    {
                        foreach (User user in Allemps)
                        {
                            all.Add(new Attendance(mDate, isStart ? mTime : null, isStart ? null : mTime, isHoliday, isRamadan));
                            allCode.Add(user.code);
                        }
                    }
                    else if (startendbtn.Text == "dayOff" || startendbtn.Text == "Sickness")
                    {
                        MessageBox.Show("Please select just one");
                        return;
                    }
                    else if (startendbtn.Text == "Annual Vacation" || startendbtn.Text == "Official Holiday")
                    {
                        foreach (User user in Allemps)
                        {
                            all.Add(new Attendance(mDate, startendbtn.Text, startendbtn.Text, isHoliday, isRamadan));
                            allCode.Add(user.code);
                        }
                    }
                    else if (startendbtn.Text == "workFromHome")
                    {
                        foreach (User user in Allemps)
                        {
                            all.Add(new Attendance(mDate, "workFromHome", mTime, isHoliday, isRamadan));
                            allCode.Add(user.code);
                        }
                    }


                }
                else {

                    return;
                }

            }
                else
                {
                    all.Clear();
                    KeyValuePair<string, string> selectedEntry = (KeyValuePair<string, string>)comboBox1.SelectedItem;
                    var selectedKey = selectedEntry.Key;
                     allCode.Add(selectedKey);
                if (startendbtn.Text == "Start" || startendbtn.Text == "End")
                {
                    all.Add(new Attendance(mDate, isStart ? mTime : null, isStart ? null : mTime, isHoliday, isRamadan));
                    
                } else if (startendbtn.Text == "dayOff" || startendbtn.Text == "Sickness" || startendbtn.Text == "Annual Vacation" || startendbtn.Text == "Official Holiday") {
                    all.Add(new Attendance(mDate, startendbtn.Text, startendbtn.Text, isHoliday, isRamadan));
                }
                else if (startendbtn.Text == "workFromHome")
                {

                    all.Add(new Attendance(mDate, "workFromHome", mTime, isHoliday, isRamadan));
                }
            }
            if (allRadio.Checked)
            {
                  await  myTools.Button_Click(attendanceServices.EditAttendance(allCode, all));
                
            }
            else {
                await myTools.Button_Click(attendanceServices.EditAttendance(allCode, all));

            }

            // "Annual Vacation" ||"Sickness" || "Official Holiday"
            //DayOff
            //Annual Vacation
            //Official Holiday
            //Sickness
            //workFromHome
        }


        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
              isHoliday = !isHoliday;
        }



        private void Attendanceform_Load(object sender, EventArgs e)
        {
            myTools = new MyTools(currentForm: this);
            mDate = DateTime.Now.ToString("dddd, dd MMMM");
            dateview.Text = mDate;
            mTime = DateTime.Now.ToString("HH:mm");
            timeviewer.Text = mTime;
            ShowEmps();
            comboBox1.SelectedIndex = 0;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ShowEmps() {
            Dictionary<string,string> comboSource = new Dictionary<string, string>();
            if (Allemps != null) {
                foreach (User user in Allemps)
                {
                    comboSource.Add(user.code, user.name);
                }
                comboBox1.DataSource = new BindingSource(comboSource, null);
                comboBox1.DisplayMember = "Value";
                comboBox1.ValueMember = "Key";
            }
        }

        private void AllRadio_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;

        }

        private void SelectRadio_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            startendbtn.Text = "Start";
            OptionalCB.Enabled = false;
        }

        private void EndRadio_CheckedChanged(object sender, EventArgs e)
        {
            startendbtn.Text = "End";
            OptionalCB.Enabled = false;
        }

        private void Dateview_ValueChanged(object sender, EventArgs e)
        {
            mDate = dateview.Value.ToString("dddd, dd MMMM");
        }

        private void Attendancebtn_Click(object sender, EventArgs e)
        {
                myTools.Opennewform(new AttendanceTableForm(Allemps,timeController));
           

        }

        private void RamadanCB_CheckedChanged(object sender, EventArgs e)
        {
            isRamadan = !isRamadan;
        }

        private void OptionalRadio_CheckedChanged_1(object sender, EventArgs e)
        {
            OptionalCB.Enabled = true;

        }

        private void OptionalCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DayOff
            //Annual Vacation
            //Official Holiday
            //Sickness
            //Work From Home

            var x = OptionalCB.SelectedItem as string;
            
                startendbtn.Text=x;
            
        }

        private void Attendancebdbtn_Click(object sender, EventArgs e)
        {
            myTools.Opennewform(new Attendancebyday(Allemps,this,timeController));
        }

        private void Timeviewer_ValueChanged(object sender, EventArgs e)
        {
            mTime = timeviewer.Text;
        }

        private async void DeleteDayBtn_Click(object sender, EventArgs e)
        {
            List<User> allCode = new List<User>();
            if (allRadio.Checked)
            {
                allCode = Allemps;
            }
            else {
                KeyValuePair<string, string> selectedEntry = (KeyValuePair<string, string>)comboBox1.SelectedItem;
                var selectedKey = selectedEntry.Key;
                allCode.Add(Allemps.Find((User user) => user.code == selectedKey));
            }
            if (myTools.CheckPassword()) {
                await myTools.Button_Click(attendanceServices.DeleteDay(allCode,dateview.Value));

            }
            else {
                MessageBox.Show("Wrong Password");
            }
        }
    }
}
