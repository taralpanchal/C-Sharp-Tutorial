using System;

namespace Hello_World
{
    class Program
    {

        static void Main(string[] args)
        {
            var random = new Random();

            //for (var i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(random.Next());
            //}

            //for (var i = 0; i < 10; i++)
            //    Console.WriteLine((char)random.Next(65,95));



            const int passwordlenght = 10;

            var buffer = new char[passwordlenght];

            for (var i = 0; i < passwordlenght; i++)
            {
                 buffer[i] = (char)('a' + random.Next(0,26));
            }
                var password = new string(buffer);
                Console.WriteLine(password);

        }
    }
}
