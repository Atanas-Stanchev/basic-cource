using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var town = Console.ReadLine();
            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
            */
            /*
            double a = 15.3;
            Console.WriteLine(Math.Ceiling(a));
            Console.WriteLine(Math.Round(a));
            Console.WriteLine(Math.Floor(a));
            Console.WriteLine(Math.Round(a,2));
            */
            /*
            Console.Write("Radius = ");
            double r = double.Parse(Console.ReadLine());
            double area = r * r * Math.PI;
            double perimeter = 2 * r * Math.PI;

            Console.WriteLine("Area = {0}", area);
            Console.WriteLine("Perimeter = {0}", perimeter);
            */

            /*
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            
            double width = Math.Abs(x1 - x2);
            double height = Math.Abs(y1 - y2);

            Console.WriteLine("Area = {0}", width * height );
            */

            /* Лице на трапец - успешно
            var b1 = double.Parse(Console.ReadLine());
            var b2 = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var area = (b1 + b2) * (h / 2);
            Console.WriteLine("Trapezoid area = " + area);
            */

            /* Периметър и лице на кръг
            var r = double.Parse(Console.ReadLine());
            var area = Math.PI * r * r;
            var perimeter = 2 * Math.PI * r;
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
            */
            /* Лице на трапец в равнина
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double width = Math.Abs(x1 - x2);
            double hight = Math.Abs(y1 - y2);
            Console.WriteLine("Area = {0}", width * hight);
            Console.WriteLine("Perimeter = {0}",(width + hight) * 2);
            */
            /* Лице на триъгълник
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = (a * h) / 2;
            Console.WriteLine(Math.Round(area,2));
            */
            /* Целзий във Фаренхайт
            double c = double.Parse(Console.ReadLine());
            double farenheit = (c * 1.8 + 32);
            Console.WriteLine(Math.Round(farenheit, 2));
            */
            /* Преобразува радиани в градуси
            double rad = double.Parse(Console.ReadLine());
            double deg = Math.Round((rad * 57.29578),0);
            Console.WriteLine(deg);
            */
            /*USD in BGN
            double USD = Double.Parse(Console.ReadLine());
            double BGN = Math.Round((USD * 1.79549),2);
            Console.WriteLine( BGN + " BGN");
            */
            /* Конвертиране на валута
            decimal moneyToConvert = decimal.Parse(Console.ReadLine());
            string firstCurrency = Console.ReadLine();
            string secondCurrency = Console.ReadLine();

            decimal firstRate = 0.0m;
            decimal secondRate = 0.0m;

            if (firstCurrency == "BGN")
            {
                firstRate = 1;
            }
            else if (firstCurrency == "USD")
            {
                firstRate = 1.79549m;
            }
            else if (firstCurrency == "EUR")
            {
                firstRate = 1.95583m;
            }
            else if (firstCurrency == "GBP")
            {
                firstRate = 2.53405m;
            }
            if (secondCurrency == "BGN")
            {
                secondRate = 1;
            }
            else if (secondCurrency == "USD")
            {
                secondRate = 1.79549m;
            }
            else if (secondCurrency == "EUR")
            {
                secondRate = 1.95583m;
            }
            else if (secondCurrency == "GBP")
            {
                secondRate = 2.53405m;
            }

            decimal result = moneyToConvert * (firstRate / secondRate );
            Console.WriteLine("{0} {1}",Math.Round(result,2), secondCurrency);
            */
            /* Конвертиране с Dictionary
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
            Console.WriteLine("{0} {1}", Math.Round(result,2), secondCurrency);
            */

            // Задача "РожденДен" от изпити - 100/100
            /*
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            double volume = (a*b*c);
            double liters = volume * 0.001;
            double percent = p * 0.01;
            Console.WriteLine("{0:f3}",(liters * (1-percent)));
            */
            // Прости проверки с "if"
            /*
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 5.50)
            {
                Console.WriteLine("Rate is exellent!");
            }
            else
            {
                Console.WriteLine("Not Exellent");
            }            
            */

            // изписва само втория ред
            /*
            int number = int.Parse(Console.ReadLine());
            if (number > 6)
            {
                Console.WriteLine("Larger!");
            }
            else if (number > 4)
            {
                Console.WriteLine("larger than 4");
            }
            else
            {
                Console.WriteLine("Smaller");
            }
            */









        }
    }
}