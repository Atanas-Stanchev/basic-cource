using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            var a = double.Parse(Console.ReadLine());

            if (figure == "square")
            {
                Console.WriteLine(a * a);
            }
            else if (figure == "rectangle")
            {
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine(a * b);
            }
            else if (figure == "circle")
            {
                double b = Math.PI;
                Console.WriteLine(Math.Round(b * (a * a), 3));
            }
            else if (figure == "triangle")
            {
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine((a * b) / 2);
            }
        }
    }
}
