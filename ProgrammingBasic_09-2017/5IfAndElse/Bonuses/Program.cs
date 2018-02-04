using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonuses
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double bonus = 0;
            if (num <= 100)
            {
                bonus = 5;
            }
            else if (num < 1000)
            {
                bonus = num * 0.20;
            }
            else if (num > 1000)
            {
                bonus = num * 0.10;
            }
            if (num % 2 == 0)
            {
                bonus++;
            }
            else if (num % 10 == 5)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(num + bonus);

            /*
             var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var s = a + b + c;
            var minutes = s / 60;
            var seconds = s % 60;
            if (seconds < 10)
            {
                Console.WriteLine(minutes + ":0" + seconds);  
            }
            else
            {
                Console.WriteLine(minutes + ":" + seconds);
            } 
            */

            /*
             * Console.WriteLine("Enter score: ");
            int num = int.Parse(Console.ReadLine());
            double bonus = 0;
            if (num <= 100)
            {
                bonus = 5;
            }
            else if (num <= 1000)
            {
                bonus = num * 0.20;
            }
            else if (num > 1000)
            {
                bonus = num * 0.10;
            }
                
            if (num % 2 == 0)
            {
                bonus += 1;
            }
            else if (num % 10 == 5)
            {
                bonus += 2;
            }
            Console.WriteLine("Bonus score: {0}", bonus);
            Console.WriteLine("Total score: {0}",  bonus + num);
            
            */
        }
    }
}
