using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            var inches = double.Parse(Console.ReadLine());
            var cantimeters = inches * 2.54;
            Console.Write("Cantimeters = ");
            Console.WriteLine(cantimeters);
        }
    }
}
