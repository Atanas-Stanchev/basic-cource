using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunGlasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());


            Console.WriteLine("{0}{1}{0}",new string ('*',2*n), new string(' ',n));
            string slashes = new string('/', 2 * n - 2);
            string spaces = new string(' ', n);
            string pipes = new string('|', n);

            for (int row = 0; row < n-2; row++)
            {
                if ((n % 2 == 0 && row == n/2 -2) || (n % 2 == 1 && row == n/ 2 - 1))
                {                     
                  Console.WriteLine($"*{slashes}*{pipes}*{slashes}*");

                }else
                {
                    Console.WriteLine($"*{slashes}*{spaces}*{slashes}*");
                }
            }
            Console.WriteLine("{0}{1}{0}",new string ('*',2*n), new string(' ',n));
            /* Another way
            int size = int.Parse(Console.ReadLine());
            int formula = size *2;
            string border = new string('*',formula);
            string middleBorder = new string(' ',size);
            string topAndBothRow = border + middleBorder + border;

            Console.WriteLine("{0}{1}{0}",border,middleBorder);

            int targetRow = (size - 1)/ 2 - 1;
            for (int row = 0; row < size - 2; row++)
            {
                char symbol = ' ';

                if (row == targetRow)
                {
                    symbol = '|';
                }

                string forwardSplash = new string('/',formula - 2);
                string middlePart = new string(symbol,size);
                Console.WriteLine("*{0}*{1}*{0}*", forwardSplash,middlePart);
            }
            */

        }
    }
}
