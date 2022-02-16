using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmgManagerSheet.Models
{
    public class TimeController
    {
        public string RegCM;
        public string RegCF;
        public string RamCM;
        public string RamCF;
        public string RegMM;
        public string RegMF;
        public string RamMM;
        public string RamMF;

        public TimeController(string RegCM, string RegCF, string RamCM, string RamCF,string RegMM, string RegMF, string RamMM,string RamMF) {
            this.RegCM = RegCM;
            this.RegCF = RegCF;
            this.RamCM = RamCM;
            this.RamCF = RamCF;
            this.RegMM = RegMM;
            this.RegMF = RegMF;
            this.RamMM = RamMM;
            this.RamMF = RamMF;
        }
    }
}
