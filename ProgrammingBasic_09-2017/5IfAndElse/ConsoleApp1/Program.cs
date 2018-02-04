using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            {

                var volume = double.Parse(Console.ReadLine());
                var pipe1 = double.Parse(Console.ReadLine());
                var pipe2 = double.Parse(Console.ReadLine());
                var hours = double.Parse(Console.ReadLine());

                var pipe1Time = pipe1 * hours;
                var pipe2Time = pipe2 * hours;
                var moment = pipe1Time + pipe2Time;
                var volumeProcent = Math.Truncate(moment * 100 / volume);
                var pipe1Procent = Math.Truncate(pipe1Time * 100 / moment);
                var pipe2Procent = Math.Truncate(pipe2Time * 100 / moment);
                var overflow = moment - volume;

                if (moment <= volume)
                {
                    Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", volumeProcent, pipe1Procent, pipe2Procent);

                }
                else
                {
                    Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, overflow);
                }



            }
        }
    }
}