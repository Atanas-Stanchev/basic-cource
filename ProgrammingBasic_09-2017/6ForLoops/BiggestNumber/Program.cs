using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine()); // Става и с Min.Value

            for (int i = 0; i < n - 1; i++)         //но трябва да махнем -1 
            {
                int number = int.Parse(Console.ReadLine());
                if (number > max)
                {
                    max = number;
                }

            }
            Console.WriteLine(max);

        }
    }
}