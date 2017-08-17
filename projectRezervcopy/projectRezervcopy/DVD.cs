using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectRezervcopy
{
    public class DVD:Storage
    {
        public double SpeedIO { get; set; }
        
        public double TypeUnilateral { get; set; }
        public double TypeBilateral { get; set; }
        public DVD(string name,string model):base(name,model)
        {
                
        }
    }
}
