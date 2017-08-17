using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectRezervcopy
{
    public class HDD:Storage
    {
        public double SpeedUSB2 { get; set; }
        public int Section { get; set; }
        public int AmountSection { get; set; }
        public HDD(string name, string model) : base(name, model)
        {
        }
        
        
    }
}
