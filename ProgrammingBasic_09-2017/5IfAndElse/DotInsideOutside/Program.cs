using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotInsideOutside
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

            // (((x == x1 || x == x1) && y <= y2 && y >= y1)) ||
            //(y == y1 || y == y2) && x >= x1 && x <= x2

            bool onLeftSide = (x == x1) && y <= y2 && y >= y1;
            bool onRightSide = (x == x2) && y <= y2 && y >= y1;
            bool onUpSide = (y == y1) && x <= x2 && x >= x1;
            bool onDownSide = (y == y1) && y <= x2 && x >= x1;

            if (onLeftSide || onRightSide || onUpSide || onDownSide)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
