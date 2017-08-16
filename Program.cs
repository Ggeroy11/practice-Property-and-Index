using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            RangeOfArray range = new RangeOfArray();
            Random random = new Random();
            Console.WriteLine("Write low index array");
            range.highIndex = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Write high index array");
            range.lowIndex = Int32.Parse(Console.ReadLine());

            for (int i=0;i<=range.highIndex ;++i) {
                range.array[i] = random.Next(0, 100);
            }
            for (int i=0; i<=range.highIndex;++i) {
                Console.WriteLine("");
            }

            

            
            
        }
    }
}
