using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var number = 52;
                string str = "Hello";
                byte b = Convert.ToByte(number);
                char c = Convert.ToChar(number);
                bool bl = Convert.ToBoolean(str);
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(bl);

            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be convert to a byte");
            }
        }
    }
 }
      