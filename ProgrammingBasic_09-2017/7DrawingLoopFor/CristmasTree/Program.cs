using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            string middle = " | ";

            for (int rows = 0; rows <= n; rows++)

            {
                string spaces = "";
                string stars = "";
                for (int space = 0; space < n-rows; space++)
                {
                    spaces += " ";
                }
                for (int star = 0; star < rows; star++)
                {
                    stars += "*";
                }
                Console.WriteLine($"{spaces}{stars}{middle}{stars}");

            }

        }
    }
}
