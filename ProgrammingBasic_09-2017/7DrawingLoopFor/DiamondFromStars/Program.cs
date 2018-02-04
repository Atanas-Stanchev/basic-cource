using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondFromStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

           
            for (int row = 1; row <= n; row++)
            { 
             
                for (int spaces = 0; spaces < n - row; spaces++)
                {
                    Console.Write(" ");
                }
                for (int stars = 0; stars < row; stars++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= n-1; i++)
            {
                for (int spaces = 0; spaces < i; spaces++)
                {
                    Console.Write(" ");
                }
                for (int stars = 0; stars < n-i; stars++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
