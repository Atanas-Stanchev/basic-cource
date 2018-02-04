using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersestingDateTimeNow
{
    class Program
    {
        static void Main(string[] args)
        {
            var startTime = DateTime.Now;

            for (int i = 0; i < 10000; i++)
            {

            }
            var endTime = DateTime.Now;
            Console.WriteLine(endTime - startTime);




        }
    }
}
