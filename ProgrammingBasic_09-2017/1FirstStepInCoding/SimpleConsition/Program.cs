using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsition
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var grade = double.Parse(Console.ReadLine());
            if (grade >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not Excellent.");
            }
            */

            /* четни и нечетни
            var num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
            */

            /*
             Console.WriteLine("Ënter two integers:");
             var num1 = int.Parse(Console.ReadLine());
             var num2 = int.Parse(Console.ReadLine());
             if (num1 > num2)
             {
                 Console.WriteLine("Graeter number " + num1);
             }
             else
             {
                 Console.WriteLine("Graeter number " + num2);
             }
             */
            /*
            int num = int.Parse(Console.ReadLine());   
            if (num == 1)
            {
                Console.WriteLine("one");
            }
            if (num == 2)
            {
                Console.WriteLine("two");
            }
            if (num == 3)
            {
                Console.WriteLine("three");
            }
            if (num == 4)
            {
                Console.WriteLine("four");
            }
            if (num == 5)
            {
                Console.WriteLine("five");
            }
            if (num == 6)
            {
                Console.WriteLine("six");
            }
            if (num == 7)
            {
                Console.WriteLine("seven");
            }
            if (num == 8)
            {
                Console.WriteLine("eight");
            }
            if (num == 9)
            {
                Console.WriteLine("nine");
            }
            if (num >= 10)
            {
                Console.WriteLine("number too big");
            }
            */

            /*
            Console.WriteLine("Enter score: ");
            int num = int.Parse(Console.ReadLine());
            double bonus = 0;
            if (num <= 100)
            {
                bonus = 5;
            }
            else if (num <= 1000)
            {
                bonus = num * 0.20;
            }
            else if (num > 1000)
            {
                bonus = num * 0.10;
            }
                
            if (num % 2 == 0)
            {
                bonus += 1;
            }
            else if (num % 10 == 5)
            {
                bonus += 2;
            }
            Console.WriteLine("Bonus score: {0}", bonus);
            Console.WriteLine("Total score: {0}",  bonus + num);
            
            /*
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var s = a + b + c;
            var minutes = s / 60;
            var seconds = s % 60;
            if (seconds < 10)
            {
                Console.WriteLine(minutes + ":0" + seconds);  
            }
            else
            {
                Console.WriteLine(minutes + ":" + seconds);
            }
            

            */

            //other 
            /*
            int num = int.Parse(Console.ReadLine());
            double bonus = 0;
            if (num <= 100)
            {
                bonus = 5;
            }
            else if (num < 1000)
            {
                bonus = num * 0.20;
            }
            else if (num > 1000)
            {
                bonus = num * 0.10;
            }
            if (num % 2 == 0)
            {
                bonus++;
            }
            else if (num % 10 == 5)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(num + bonus);
            */
            /* Password
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

            Console.WriteLine();
            */
            /* Num from 100 to 200
            int number = int.Parse(Console.ReadLine());

            if (number < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (number >= 100 && number <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            if (number > 200)
            {
                Console.WriteLine("Greater than 200");
            }
            */
            /* Проверка за еднакви символи (с намаляване на шрифта)
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
            */

            /* 16 .Speed info 100/100
            double speed = double.Parse(Console.ReadLine());
            if (speed <= 10 )
            {
                Console.WriteLine("slow");
            }
            else if (speed > 10 && speed <=50)
            {
                Console.WriteLine("average");
            }
            else if  (speed > 50 && speed <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (speed > 150 && speed <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else if (speed > 1000)
            {
                Console.WriteLine("extremely fast");
            }
           */
            /* areas of Figures 100/100
             var figure = Console.ReadLine();
             var a = double.Parse(Console.ReadLine());

             if (figure == "square")
             {
                 Console.WriteLine(a*a);
             }
             else if (figure == "rectangle")
             {
                 var b = double.Parse(Console.ReadLine());
                 Console.WriteLine(a*b);
             }
             else if (figure == "circle")
             {
                 double b = Math.PI;
                 Console.WriteLine(Math.Round(b * (a*a),3));
             }
             else if (figure == "triangle")
             {
                 double b = double.Parse(Console.ReadLine());
                 Console.WriteLine((a*b)/2);
             }
             */
            /* 3 numbers 100/100
           double a = double.Parse(Console.ReadLine());
           double b = double.Parse(Console.ReadLine());
           double c = double.Parse(Console.ReadLine());

           if (a == b && b == c)
           {
               Console.WriteLine("yes");
           }
           else  
           {
               Console.WriteLine("no");
           }
           */

            /* перфектното решение
            double hour = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());

            if (minutes + 15 > 59)
            {
                hour += 1;
                minutes = 15 - (60 - minutes);
            }
            else if (minutes + 15 <= 59)
            {
                minutes += 15;
            }
            if (hour == 24) hour = 0;
            Console.WriteLine("{0}:{1:00}",hour , minutes);
            */
            /* 88/100
            int number = int.Parse(Console.ReadLine());
            string[] a = {"zero","one","two","three", "four", "five","six","seven","eight","nine","ten"};
            string[] b = {"eleven","twelve","thirteen","fourteen","fifteen","siteen","seventeen","eighteen","nineteen",};
            string[] c = { "twenty","thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};

            int num2 = number % 10;
            int num1 = (number - num2) / 10;

            if (number >= 0 && number <= 100)
            {
                if (number == 100)
                {
                    Console.WriteLine("one hundred");
                }
                else if (number <= 10)
                {
                    Console.WriteLine(a[number]);
                }
                else if (number < 20)
                {
                    Console.WriteLine(b[number % 10 - 1]);
                }
                else if (number % 10 == 0)
                {
                    Console.WriteLine(c[number / 10 - 2]);
                }
                else if (number > 20)
                {
                    Console.WriteLine(c[num1 - 2] + " " + a[num2]);
                }
                else if (number > 100)
                { 
                    Console.WriteLine("invalid number");
                }
            else 
            {
               Console.WriteLine("invalid number");
            }
            */
            /* 83/100 Такси Влак Автобус
            var n = double.Parse(Console.ReadLine());
            var b = Console.ReadLine();
            var taxiDay = ((0.79 * n) + 0.70);
            var taxiNight = ((0.90 * n) + 0.70);
            var bus = 0.09 * n;
            var train = 0.06 * n;

            if (n < 20)
            {
                if (b == "night") { Console.WriteLine(taxiNight); }
                else if (b == "day") { Console.WriteLine((taxiDay)); }
            }
            else if (n >= 20 && n < 100)
            {
                Console.WriteLine(bus);
            }
            else if (n > 100)
            {
                Console.WriteLine(train);
            }
            */

            double volume = double.Parse(Console.ReadLine());
            double pipe1 = double.Parse(Console.ReadLine());
            double pipe2 = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());


            if ((hours *pipe1 + pipe2) > volume)
            {

            }

        }
    }
}