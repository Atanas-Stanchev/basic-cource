using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidPass
{
    class StupidPass
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int firstNum = 1; firstNum <= n; firstNum++)
            {
                for (int secondNum = 1; secondNum <= n; secondNum++)
                {
                    for (char firstLetter = 'a'; firstLetter < 'a' + l; firstLetter++)
                    {
                        for (char seccondLetter = 'a'; seccondLetter < 'a' + l; seccondLetter++)
                        {
                            for (int lastNum = Math.Max(firstNum, secondNum) + 1; lastNum <= n; lastNum++)
                            {
                                if (lastNum > n)
                                {
                                    return;
                                }
                                Console.Write("{0}{1}{2}{3}{4}" + " ", firstNum, secondNum, firstLetter, seccondLetter, lastNum);
                            }
                        }
                    }
                }
            }
        }
    }
}
