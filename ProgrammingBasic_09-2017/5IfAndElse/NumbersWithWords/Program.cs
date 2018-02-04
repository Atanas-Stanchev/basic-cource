using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersWithWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] a = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            string[] b = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "siteen", "seventeen", "eighteen", "nineteen", };
            string[] c = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            int num2 = number % 10;
            int num1 = (number - num2) / 10;

            if (number >= 0 && number <= 100)
            {
                if (number == 100)
                {
                    Console.WriteLine("one hundred");
                }
                else if (number <= 10)
                {
                    Console.WriteLine(a[number]);
                }
                else if (number < 20)
                {
                    Console.WriteLine(b[number % 10 - 1]);
                }
                else if (number % 10 == 0)
                {
                    Console.WriteLine(c[number / 10 - 2]);
                }
                else if (number > 20)
                {
                    Console.WriteLine(c[num1 - 2] + " " + a[num2]);
                }
                else if (number > 100)
                {
                    Console.WriteLine("invalid number");
                }
                else
                {
                    Console.WriteLine("invalid number");
                }
            }
        }
    }
}
