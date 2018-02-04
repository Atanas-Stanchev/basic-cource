using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalculating_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {

            // По-сложни логически проверки
            /*
             double age = double.Parse(Console.ReadLine());
             string gender = Console.ReadLine();

             if (gender == "f")
             {
                 if (age < 16)
                 {
                     Console.WriteLine("Miss");
                 }
                 else
                 {
                     Console.WriteLine("Ms.");
                 }
             }
             else
             {
                 if (age < 16)
                 {

                     Console.WriteLine("Master");
                 }
                  else
                  {
                      Console.WriteLine("Mr.");
                  }
             }
             */

            /*  
             // Квартално магазинче с различни цени (дълго решение)
             var productName = Console.ReadLine();
             var town = Console.ReadLine();
             double quanity = double.Parse(Console.ReadLine());
             var finalPrice = 0.0;
             if (town == "Sofia")
             {
                  if (productName == "coffee") Console.WriteLine(finalPrice = quanity * 0.50);
                  else if (productName == "water") Console.WriteLine(finalPrice = quanity * 0.80);
                  else if (productName == "beer") Console.WriteLine(finalPrice = quanity * 1.20);
                  else if (productName == "sweets") Console.WriteLine(finalPrice = quanity * 1.45);
                  else if (productName == "peanuts") Console.WriteLine(finalPrice = quanity * 1.60);
             }
             if (town == "Plovdiv")
             {
                  if (productName == "coffee") Console.WriteLine(finalPrice = quanity * 0.40);
                  else if (productName == "water") Console.WriteLine(finalPrice = quanity * 0.70);
                  else if (productName == "beer") Console.WriteLine(finalPrice = quanity * 1.15);
                  else if (productName == "sweets") Console.WriteLine(finalPrice = quanity * 1.30);
                  else if (productName == "peanuts") Console.WriteLine(finalPrice = quanity * 1.50);

             }
             if (town == "Varna")
             {
                  if (productName == "coffee") Console.WriteLine(finalPrice = quanity * 0.45);
                  else if (productName == "water") Console.WriteLine(finalPrice = quanity * 0.70);
                  else if (productName == "beer") Console.WriteLine(finalPrice = quanity * 1.10);
                  else if (productName == "sweets") Console.WriteLine(finalPrice = quanity * 1.35);
                  else if (productName == "peanuts") Console.WriteLine(finalPrice = quanity * 1.55);
             }
             */

            /*
            bool a = 10 > 5;
            bool b = 8 > 20;

            bool result = a && b;
            Console.WriteLine(result);  
            */
            // Изчисляване на точка дали  е Inside || Outside
            /*
             double x1 = double.Parse(Console.ReadLine());
             double y1 = double.Parse(Console.ReadLine());

             double x2 = double.Parse(Console.ReadLine());
             double y2 = double.Parse(Console.ReadLine());

             double x = double.Parse(Console.ReadLine());
             double y = double.Parse(Console.ReadLine());

             if ((x >= x1 && x <= x2) && (y >= y1 && y <= y2))
             {
                 Console.WriteLine("Inside");
             }
             else
             {
                 Console.WriteLine("Outside");
             }
             */
            /*
           // 07 Зеленчуков магазин
           var fruit = Console.ReadLine().ToLower();
           var day = Console.ReadLine().ToLower();
           double quantity = double.Parse(Console.ReadLine());

           var price = -1.0;

           if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" ||
               day == "friday")
           {
               if (fruit == "banana") price = 2.50;
               else if (fruit == "apple") price = 1.20;
               else if (fruit == "orange") price = 0.85;
               else if (fruit == "grapefruit") price = 1.45;
               else if (fruit == "kiwi") price = 2.70;
               else if (fruit == "pineapple") price = 5.50;
               else if (fruit == "grapes") price = 3.85;
           }
           else if (day == "saturday" || day == "sunday")
           {
               if (fruit == "banana") price = 2.70;
               else if (fruit == "apple") price = 1.25;
               else if (fruit == "orange") price = 0.90;
               else if (fruit == "grapefruit") price = 1.60;
               else if (fruit == "kiwi") price = 3.00;
               else if (fruit == "pineapple") price = 5.60;
               else if (fruit == "grapes") price = 4.20;
           }
           if (price >= 0)
           {
               Console.WriteLine("{0:F2}", price * quantity);
           }
           else
           {
               Console.WriteLine("error");
           }
           */

            //05 плод или зеленчук
            /*
            var fruit = Console.ReadLine();

            if (fruit == "banana" || fruit == "apple" || fruit == "cherry" ||
                fruit == "lemon" || fruit == "kiwi" || fruit == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (fruit == "tomato" || fruit == "cucumber" || fruit == "pepper" ||
                fruit == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
            */
            /*
                 //4 Точка в правоъгълник
             var x1 = double.Parse(Console.ReadLine());
             var y1 = double.Parse(Console.ReadLine());
             var x2 = double.Parse(Console.ReadLine());
             var y2 = double.Parse(Console.ReadLine());
             var x = double.Parse(Console.ReadLine());
             var y = double.Parse(Console.ReadLine());


             bool isInXRange = x >= x1 && x <= x2;
             bool isInYRange = y >= y1 && y <= y2;
             bool isOnXSIde = x >= x1 && x <= x2;
             bool isOnYSide = y >= y1 && y <= y1;

             if (isOnXSIde || isOnYSide)
             {
                 Console.WriteLine("border");
             }
             */
            /* 
            var user = Console.ReadLine();
            var pass = Console.ReadLine();

            var expectedPassword = "";

            switch (user)
            {
                case "admin":
                    expectedPassword = "admin";
                    break;
                case "gosho":
                    expectedPassword = "123";
                default:
            }
           */
            /*  08 Комисионни
             string town = Console.ReadLine().ToLower();
             double sales = double.Parse(Console.ReadLine());
             var comission = -1.0;

             if (town == "sofia")
             {
                 if (0 <= sales && sales <= 500) comission = 0.05;
                 else if (500 < sales && sales <= 1000) comission = 0.07;
                 else if (1000 < sales && sales <= 10000) comission = 0.08;
                 else if (sales > 10000) comission = 0.12;
             }
             else if (town == "varna")
             {
                 if (0 <= sales && sales <= 500) comission = 0.045;
                 else if (500 < sales && sales <= 1000) comission = 0.075;
                 else if (1000 < sales && sales <= 10000) comission = 0.10;
                 else if (sales > 10000) comission = 0.13;
             }
             else if (town == "plovdiv")
             {
                 if (0 <= sales && sales <= 500) comission = 0.055;
                 else if (500 < sales && sales <= 1000) comission = 0.08;
                 else if (1000 < sales && sales <= 10000) comission = 0.12;
                 else if (sales > 10000) comission = 0.145;
             }
             if (0 < comission) 
              {
                 Console.WriteLine("{0:f2}", sales * comission);
              }
             else
             {
                 Console.WriteLine("error");
             }
             */

            /*// 06 Невалидно число

            var num = int.Parse(Console.ReadLine());
            if ((num >= 100 && num <= 200) || num == 0)
            {
                Console.WriteLine();
            }
            else if (num > 200 || num < 100)
            {
                Console.WriteLine("invalid");
            }
            */

            /* 88/100 (08. На Границата или  Вътре/Вън 
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

           // (((x == x1 || x == x1) && y <= y2 && y >= y1)) ||
            //(y == y1 || y == y2) && x >= x1 && x <= x2

            bool onLeftSide = (x == x1) && y <= y2 && y >= y1;
            bool onRightSide = (x == x2) && y <= y2 &&  y >= y1 ;
            bool onUpSide = (y == y1) && x <= x2 && x >= x1 ;
            bool onDownSide = (y == y1) && y <= x2  && x >= x1;
            
            if (onLeftSide || onRightSide || onUpSide || onDownSide)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
            */

            /* 09 Day of week
            var day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Wednesday"); break;
                case 4: Console.WriteLine("Thursday"); break;
                case 5: Console.WriteLine("Friday"); break;
                case 6: Console.WriteLine("Saturday"); break;
                case 7: Console.WriteLine("Sunday"); break;
                case -1: Console.WriteLine("Error"); break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            */
            /*
            // 11 Class animal

            string animal = Console.ReadLine();

            switch (animal)
            {
                case "dog": Console.WriteLine("mammal");break;
                case "crocodile":
                case "tortoise":
                case "snake": Console.WriteLine("reptile");break;
                case "cat": Console.WriteLine("unknown");break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
            */
            /* 11.Cinema
            string ticket = Console.ReadLine();
            var r = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            double cinema = (r * c);
            double price = 0.0;
            
            if (ticket == "Premiere")
            {
                price = 12.00;
            }
            else if (ticket == "Normal")
            {
                price = 7.50;
            }
            else if (ticket == "Discount")
            {
                price = 5.00;
            }
            var result = (cinema * price + " " + "leva");
            Console.WriteLine("{0:f2}",result);
            */
            /* Volleyball
            var year = Console.ReadLine();
            var holiday = double.Parse(Console.ReadLine());
            var travel = double.Parse(Console.ReadLine());

            var weekend = (48 - travel)*3.0/4;
            var playsWeekend = holiday * 2.0 / 3;
            var playTravel = travel;
            var sum = (weekend + playsWeekend + playTravel); 

            switch (year)
            {
                case "leap":Console.WriteLine(Math.Truncate(sum* 1.15)); break;
                case "normal": Console.WriteLine(Math.Truncate(sum));break;
                default:
                    break;
            }
            */
            
            var hh = int.Parse(Console.ReadLine());
            var mm = int.Parse(Console.ReadLine());

            var hhArival = int.Parse(Console.ReadLine());
            var mmArival = int.Parse(Console.ReadLine());
            decimal minutes = 00m;
            if (hh == hhArival && minutes == mmArival)
            {
                Console.WriteLine("On time");
            }
            else if ((hh > hhArival && mm > mmArival) || minutes == 00 )
            {                
                Console.WriteLine();               
            }
            else if (hh <= hhArival && mmArival >  )















        }
    }
}
