using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
                sum = number;
                if (sum == number)
                {
                    Console.Write("Yes sum =",sum);
                }
                else if (sum < number)
                {
                    Console.WriteLine("No,Diff =",sum - number);
                }
                
            }
            



        }
    }
}
