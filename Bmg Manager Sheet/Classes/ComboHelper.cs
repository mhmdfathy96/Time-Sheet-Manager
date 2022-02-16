using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BmgManagerSheet.Classes
{
    class ComboHelper
    {
        public string GetSelectedGender(ComboBox comboBox) {
            return (comboBox.SelectedIndex == 0) ? "Male" : "Female";
        }

        public string GetSelectedOffice(ComboBox comboBox)
        {
            return (comboBox.SelectedIndex == 0) ? "Cairo" : "Mansoura";
        }
    }
}
