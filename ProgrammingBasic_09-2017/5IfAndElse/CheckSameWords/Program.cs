using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckSameWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            word = word.ToLower();
            string word2 = Console.ReadLine();
            word2 = word2.ToLower();

            if (word == word2)
            {
                Console.WriteLine("yes");
            }
            else if (word != word2)
            {
                Console.WriteLine("no");
            }

        }
    }
}
