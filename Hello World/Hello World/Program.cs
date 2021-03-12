using System;
using System.Collections.Generic;

namespace Hello_World
{
    class Program
    {

        static void Main(string[] args)
        {
            var datetime = new DateTime(2021,03,12);

            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());

            Console.WriteLine(now);
            Console.WriteLine(today);

        }
    }
}
