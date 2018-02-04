using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciseReadNumbersVar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете страната на квадрата: a =");
            var a = double.Parse(Console.ReadLine());
            var area = a * a;
            Console.Write("Лице = ");
            Console.WriteLine(area);


        }
    }
}
