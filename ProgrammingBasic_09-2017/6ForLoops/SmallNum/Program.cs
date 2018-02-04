using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine()); // Става и с Min.Value

            for (int i = 0; i < n - 1 ; i++)         //но трябва да махнем -1 
            {
                int number = int.Parse(Console.ReadLine());
                if (number < min)
                {
                    min = number;
                }

            }
            Console.WriteLine(min);
        }
    }
}
