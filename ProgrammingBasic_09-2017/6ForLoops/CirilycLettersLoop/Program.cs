using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirilycLettersLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (char c ='а'; c <= 'я'; c++)
            {
                Console.WriteLine(c);
            }
        }
    }
}
