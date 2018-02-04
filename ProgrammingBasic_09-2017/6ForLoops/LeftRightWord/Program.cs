using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRightWord
{
    class Program
    {
        static void Main(string[] args)
        {
           

            var n = int.Parse(Console.ReadLine());

            var evenSum = 0;
            var oddSum = 0;

            for (var i = 0; i < n; i++)
            { 
                var currentNumber = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                    evenSum += currentNumber;
                else
                    oddSum += currentNumber;
            }
           
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes sum  = {0}",oddSum);
            }
            else
            {
                Console.WriteLine("No diff = {0}",Math.Abs(oddSum - evenSum));
            }
        }
    }
}
