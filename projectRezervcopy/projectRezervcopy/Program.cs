using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectRezervcopy
{
    class Program
    {
        static void Main(string[] args)
        {
            Flash flash = new Flash("Flash","Transcend");
            DVD dvd = new DVD("DVD-R","Sony");
            HDD hdd = new HDD("HDD","Hitachi");
            
            flash.Amount = 32;
            flash.SpeedUsb = 5;
            flash.InfoEmptyMemory = "MY Diplom";
            flash.GetMemory = 16;
            

            dvd.SpeedIO= 1385000;
            dvd.TypeUnilateral = 4.7;
            dvd.TypeBilateral = 9;
            hdd.SpeedUSB2 = 60;
            hdd.AmountSection = 500;
            hdd.Section = 5;
            

        }
    }
}
