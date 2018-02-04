using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            var pass = "s3cr3t!P@ssw0rd";
            var pass1 = Console.ReadLine();

            if (pass1 == pass)
            {
                Console.Write("Welcome");
            }
            else if (pass1 != pass)

            {
                Console.Write("Wrong password!");
            }
        }
    }
}
