using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDinBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD = Double.Parse(Console.ReadLine());
            double BGN = Math.Round((USD * 1.79549), 2);
            Console.WriteLine(BGN + " BGN");
        }
    }
}
