using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double oddSum = 0;
            double evenSum = 0;

            double oddMax = double.MinValue;
            double oddMin = double.MaxValue;

            double evenMax = double.MinValue;
            double evenMin = double.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += num;
                }
                if (evenMin > num && i % 2 == 0)
                {
                    evenMin = num;
                }
                if (evenMax < num && i % 2 == 0)
                {
                    evenMax = num;
                }
                if (i % 2 != 0)
                { 
                     oddSum += num;
                }
                if (oddMax < num && i % 2 != 0)
                {
                    oddMax = num;
                }
                 if (oddMin > num && i % 2 != 0)
                {
                    oddMin = num;
                }
                

            }


            if (n == 0 && n == int.MaxValue && n == int.MinValue)
            {
                Console.WriteLine("OddSum=" + ""+ 0 ,oddSum);
                Console.WriteLine("OddMin=" + "No",oddMin);
                Console.WriteLine("OddMax=" + "No");
                Console.WriteLine("EvenSum="+"" + 0);
                Console.WriteLine("EvenMin=No",evenMin);
                Console.WriteLine("EvenMax=No", evenMax);
            }
            else
            {
                Console.WriteLine("OddSum=" + oddSum + ",");
                Console.WriteLine("OddMin=" + oddMin + ",");
                Console.WriteLine("OddMax=" + oddMax + ",");
                Console.WriteLine("EvenSum=" + evenSum + ",");
                Console.WriteLine("EvenMin=" + evenMin + ",");
                Console.WriteLine("EvenMax=" + evenMax);
            }
            
        }
    }
}
