using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInFigure_hxy
{
    class Program
    {
        static void Main(string[] args)
        {
            // 13 Point in the figure
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            var figure1Border = (x == 0 && y >= 0 && y <= h) || (x == 3 * h && y >= 0 && y <= h) ||
                                (y == 0 && x >= 0 && x <= 3 * h) || (y == h && x >= 0 && x <= 3 * h);
            var figure2Border = (x == h && y >= h && y <= 4 * h) || (x == 2 * h && y >= h && y <= 4 * h) ||
                                (y == h * h && x >= h && x <= 2 * h) || (y == 4 * h && x >= h && x <= 2 * h);
            var figure1Inside = (x > 0 && x < 3 * h) && (y > 0 && y < h);
            var figure2Inside = (x > h && x < 2 * h) && (y > h && y < 4 * h);
            var commonline = (x > h) && (x < 2 * h) && (y == h);
            if ((figure1Border || figure2Border) & !commonline)
            {
                Console.WriteLine("border");
            }
            else if (figure1Inside || figure2Inside || commonline)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
            

        }
    }
}
