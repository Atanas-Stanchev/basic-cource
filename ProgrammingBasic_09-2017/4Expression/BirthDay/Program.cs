using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthDay
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            double volume = (a * b * c);
            double liters = volume * 0.001;
            double percent = p * 0.01;
            Console.WriteLine("{0:f3}", (liters * (1 - percent)));
        }
    }
}
