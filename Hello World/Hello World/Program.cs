using System;

namespace Hello_World
{
    class Program
    { 

        static void Main(string[] args)
        {
            //for loop
            //for(var i=1; i<10; i++)
            //    if(i %2 == 0)
            //          Console.WriteLine();

            //foreach loop
            //var name = "Mosh Hamdani";
            //foreach(var i in name)
            //    Console.WriteLine(i);

            //var number = new int[] { 1, 2, 3, 4, 5 };
            //{
            //    foreach(var num in number)
            //        Console.WriteLine(num);
            //}


            //While loop
          while(true)
            {
                Console.Write("Enter Name:");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo :" + input);
                    continue;
                }
                break;

            }
           
        }
    }
}
