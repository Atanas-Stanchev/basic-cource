using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var holiday = double.Parse(Console.ReadLine());
            var travel = double.Parse(Console.ReadLine());

            var weekend = (48 - travel) * 3.0 / 4;
            var playsWeekend = holiday * 2.0 / 3;
            var playTravel = travel;
            var sum = (weekend + playsWeekend + playTravel);

            switch (year)
            {
                case "leap": Console.WriteLine(Math.Truncate(sum * 1.15)); break;
                case "normal": Console.WriteLine(Math.Truncate(sum)); break;
                default:
                    break;
            }
        }
    }
}
