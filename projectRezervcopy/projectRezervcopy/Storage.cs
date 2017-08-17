using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectRezervcopy
{
    public abstract class Storage
    {
        protected string name;
        protected string model;
        public int GetMemory { get; set;}
        public int [] CopyFile { get; set;}
        public string InfoEmptyMemory { get; set; }
        public string AllInfoDevice { get; set; }
        public Storage(string name,string model)
        {
            this.name = name;
            this.model = model;
        }
        


    }
}
