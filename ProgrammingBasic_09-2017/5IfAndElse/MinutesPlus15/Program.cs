using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinutesPlus15
{
    class Program
    {
        static void Main(string[] args)
        {
            double hour = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());

            if (minutes + 15 > 59)
            {
                hour += 1;
                minutes = 15 - (60 - minutes);
            }
            else if (minutes + 15 <= 59)
            {
                minutes += 15;
            }
            if (hour == 24) hour = 0;
            Console.WriteLine("{0}:{1:00}", hour, minutes);
        }
    }
}
