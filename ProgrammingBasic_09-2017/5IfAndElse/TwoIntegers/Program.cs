using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ënter two integers:");
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("Graeter number " + num1);
            }
            else
            {
                Console.WriteLine("Graeter number " + num2);
            }
            
            
        }
    }
}
