using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticket = Console.ReadLine();
            var r = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            double cinema = (r * c);
            double price = 0.0;

            if (ticket == "Premiere")
            {
                price = 12.00;
            }
            else if (ticket == "Normal")
            {
                price = 7.50;
            }
            else if (ticket == "Discount")
            {
                price = 5.00;
            }
            var result = (cinema * price + " " + "leva");
            Console.WriteLine("{0:f2}", result);
        }
    }
}
