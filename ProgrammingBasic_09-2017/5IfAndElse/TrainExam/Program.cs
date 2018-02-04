using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainExam
{
    class Program
    {
        static void Main(string[] args)
        {
            // Шивашки цех
            double num = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double cover = num * (lenght + 2 * 0.30) * (width + 2 * 0.30);
            double box = num * (lenght / 2) * (lenght / 2);
            
            double priceCover = ((cover * 7) + box * 9);
            double price = (priceCover * 1.85);

            Console.WriteLine("{0:f2} USD",priceCover);
            Console.WriteLine("{0:f2} BGN",price);
        }
    }
}
