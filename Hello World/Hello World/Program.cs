using System;

namespace Hello_World
{
    class Program
    { 

        static void Main(string[] args)
        {
            /* var hour = 15;
             var goldCustomer = true;
             float price;
             if(goldCustomer)
                 price = 25.50f;
             else
                 price = 30.70f;

               if(hour > 0 && hour < 12)
                   Console.WriteLine("Good Morning");
               else if(hour >= 12 && hour < 18)
                   Console.WriteLine("Good Afternoon");
               else
                   Console.WriteLine("Good Evening");
             
            // var price =  (goldCustomer) ? 18.80 : 23.50;
            Console.WriteLine(price);*/
            var session1 = session.Winter;
            switch(session1)
            {
                case  session.Autumn:
                    Console.WriteLine("It's Autumn");
                    break;
                case session.Winter:
                    Console.WriteLine("It's Winter");
                    break;
                default:
                    Console.WriteLine("normal");
                    break;
            }
        }
    }
}
