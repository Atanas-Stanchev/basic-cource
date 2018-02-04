using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotInFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());


            bool isInXRange = x >= x1 && x <= x2;
            bool isInYRange = y >= y1 && y <= y2;
            bool isOnXSIde = x >= x1 && x <= x2;
            bool isOnYSide = y >= y1 && y <= y1;

            if (isOnXSIde || isOnYSide)
            {
                Console.WriteLine("border");
            }
        }
    }
}
