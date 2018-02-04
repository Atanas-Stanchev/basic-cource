using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusFarenhaeit
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double c = double.Parse(Console.ReadLine());
            double farenheit = (c * 1.8 + 32);
            Console.WriteLine(Math.Round(farenheit, 2));
          
        }
    }
}
