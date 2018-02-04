using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareTrapez
{
    class Program
    {
        static void Main(string[] args)
        {
            // трапец в равнина
            /*
             double x1 = double.Parse(Console.ReadLine());
             double y1 = double.Parse(Console.ReadLine());
             double x2 = double.Parse(Console.ReadLine());
             double y2 = double.Parse(Console.ReadLine());
             double width = Math.Abs(x1 - x2);
             double hight = Math.Abs(y1 - y2);
             Console.WriteLine("Area = {0}", width * hight);
             Console.WriteLine("Perimeter = {0}",(width + hight) * 2);
           */
            var b1 = double.Parse(Console.ReadLine());
            var b2 = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var area = (b1 + b2) * (h / 2);
            Console.WriteLine("Trapezoid area = " + area);

        }
    }
}
