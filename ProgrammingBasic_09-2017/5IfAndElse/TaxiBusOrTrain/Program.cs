using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBusOrTrain
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var b = Console.ReadLine();
            var taxiDay = ((0.79 * n) + 0.70);
            var taxiNight = ((0.90 * n) + 0.70);
            var bus = 0.09 * n;
            var train = 0.06 * n;

            if (n < 20)
            {
                if (b == "night") { Console.WriteLine(taxiNight); }
                else if (b == "day") { Console.WriteLine((taxiDay)); }
            }
            else if (n >= 20 && n < 100)
            {
                Console.WriteLine(bus);
            }
            else if (n > 100)
            {
                Console.WriteLine(train);
            }
        }
    }
}
