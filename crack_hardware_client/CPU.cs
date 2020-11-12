using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrackHardware
{
    [Serializable]
    public class CPU
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
    }
}
