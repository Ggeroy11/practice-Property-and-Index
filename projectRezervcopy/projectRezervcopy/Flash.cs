using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectRezervcopy
{
    public class Flash:Storage
    {
        public double SpeedUsb {get; set;}
        public double Amount {get; set;}
        public Flash(string name,string model):base(name, model)
        {

        }

    }
}
