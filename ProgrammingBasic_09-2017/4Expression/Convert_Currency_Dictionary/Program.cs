using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Currency_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal moneyToConvert = decimal.Parse(Console.ReadLine());
            string firstCurrency = Console.ReadLine();
            string secondCurrency = Console.ReadLine();

            var currencies = new Dictionary<string, decimal>()
                                   {
                    {"USD",1.79549m},
                    {"BGN,",1m},
                    {"EUR",1.95583m},
                    {"GBP",2.53405m}
                                   };
            decimal result = moneyToConvert * (currencies[firstCurrency] / currencies[secondCurrency]);
            Console.WriteLine("{0} {1}", Math.Round(result, 2), secondCurrency);
        }
    }
}
