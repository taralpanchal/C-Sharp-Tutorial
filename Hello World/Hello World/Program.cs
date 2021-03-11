using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 5;
            var c = 3;
            Console.WriteLine( a + b + c);
            Console.WriteLine((float)a / b);
            Console.WriteLine(a + b * c);
            Console.WriteLine(a > b);
            Console.WriteLine(a != b);
            Console.WriteLine((c > b || c < a));

        }
    }
 }
        