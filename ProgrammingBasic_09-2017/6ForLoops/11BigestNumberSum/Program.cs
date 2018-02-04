using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11BigestNumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sum = 0;
            var max = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > max)
                {
                    max = num;
                }
            }

            if (max == sum - max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", max );
            }
            else
            {
                var difference = Math.Abs(max - (sum - max));
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}",difference);
            }


        }
    }
}
