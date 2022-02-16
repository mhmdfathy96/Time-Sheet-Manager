using System;
using System.Windows.Forms;
using BmgManagerSheet.DataBase.TimeControllerServices;
using BmgManagerSheet.Models;

namespace BmgManagerSheet.Forms.ControllerComponents
{
    
    public partial class ControllerForm : Form
    {

        private MyTools myTools;
        private static TimeController timeController;
        private readonly TimeControllerServices timeControllerServices = new TimeControllerServices();
        public ControllerForm(TimeController timeControllerr)
        {
          InitializeComponent();
          timeController = timeControllerr;
        }

        private void ControllerTitle_Click(object sender, EventArgs e)
        {

        }

        private void TimeControllerProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void TCBackBtn_Click(object sender, EventArgs e)
        {
            myTools.Opennewform(new Main());
        }

        private async void TimeControllerEdittor_Click(object sender, EventArgs e)
        {
            TimeController timeController = new TimeController(
                RegCMtxt.Text,
                RegCFtxt.Text,
                RamCMtxt.Text,
                RamCFtxt.Text,
                RegMMtxt.Text,
                RegMFtxt.Text,
                RamMMtxt.Text,
                RamMFtxt.Text
                );
         await myTools.Button_Click( timeControllerServices.UpdateSettings(timeController));
        }

        private void ControllerForm_Load(object sender, EventArgs e)
        {
            myTools = new MyTools(currentForm: this);
            TimeController timeController1= timeController;
            if (timeController1 != null) {
                RegCMtxt.Text = timeController1.RegCM;
                RegCFtxt.Text = timeController1.RegCF;
                RamCMtxt.Text = timeController1.RamCM;
                RamCFtxt.Text = timeController1.RamCF;
                RegMMtxt.Text = timeController1.RegMM;
                RegMFtxt.Text = timeController1.RegMF;
                RamMMtxt.Text = timeController1.RamMM;
                RamMFtxt.Text = timeController1.RamMF;
            }
        }
    }
}
