using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrackHardware
{
    [Serializable]
    public class CrackHardware
    {
        public string BOIS { get; set; }
        public List<CPU> AllCPU { get; set; } = new List<CPU>();
        public List<string> AllDisk { get; set; } = new List<string>();
        public List<string> AllNetCard { get; set; } = new List<string>();
        public string FirstCPUName {
            get {
                if (AllCPU.Count > 0) {
                    return AllCPU[0].Name;
                }
                return "未检测到CPU";
            }
        }

        internal string GetFirstCPU()
        {
            string cpu = "";
            if (AllCPU.Count > 0) {
                cpu = AllCPU[0].Manufacturer.ToUpper() + AllCPU[0].Id.ToUpper();
            }

            return cpu;
        }
    }
}
