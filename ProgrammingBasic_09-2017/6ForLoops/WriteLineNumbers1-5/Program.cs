using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteLineNumbers1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете брой числа n =");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете {0} числа едно след друго на отеделен ред",n);

            for (int i = 1; i <= n; i++)
            {
                Console.Write("n {0} = ",i);
                var num = int.Parse(Console.ReadLine());

            }
        }
    }
}
