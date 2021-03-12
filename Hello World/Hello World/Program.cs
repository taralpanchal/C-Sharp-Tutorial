using System;


namespace Hello_World
{
    class Program
    {

        static void Main(string[] args)
        {
            var timespan = new TimeSpan(1, 2, 3);
            Console.WriteLine(timespan);
            var hour = TimeSpan.FromHours(3);

            var addmintes = timespan.Add(TimeSpan.FromMinutes(8));
            Console.WriteLine("Add Minutes: "+addmintes);

            var sbtract = timespan.Subtract(TimeSpan.FromMinutes(5));
            Console.WriteLine("subtract: "+sbtract);

            Console.WriteLine("Minutes:" +timespan.Minutes);
            Console.WriteLine("Total Minutes: "+timespan.TotalMinutes);

           

            //Console.WriteLine(TimeSpan.Parse("01-03-05"));

                
        }
    }
}
