using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int width = n;
            int starsCount = 1;
            
            if (n % 2 == 0 )
            {
                starsCount++;
            }

            for (int row = 0; row < (n + 1)/2; row++)
            {
                string dashes = new string('-',(width - starsCount) / 2);
                string stars = new string('*',starsCount);

                Console.WriteLine($"{dashes}{stars}{dashes}");
                starsCount += 2;
            }

            for (int row = 0; row < n - (n+1)/2; row++)
            {
                Console.WriteLine("|{0}|", new string ('*',n-2));

            }
             /* Another way
            int size = int.Parse(Console.ReadLine());
            int countOfStars = 1;        // int countOfStars = size % 2 == 0 ? 2:1;
            if (size % 2 == 0)                       // check for True or False
            {                                       // print 2 if true
                countOfStars = 2;                   // print 1 if false    
            }
           
            int countOfDashes = (size - countOfStars) / 2;

            int roofTopRows = (size + 1) / 2;
            for (int row = 0; row < roofTopRows; row++)
            {
                string dashes = new string('-', countOfDashes);
                string stars = new string('*', countOfStars);

                Console.WriteLine("{0}{1}{0}", countOfDashes,stars);
                countOfDashes--;
                countOfStars += 2;
            }
            int bodyRow = size / 2;
            for (int row = 0; row < bodyRow; row++)
            {
                string stars = new string('*', size - 2);
                Console.WriteLine("|{0}|", stars);
            }
            */
        }
    }
}
