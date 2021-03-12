using System;

namespace Hello_World
{
    class Program
    {

        static void Main(string[] args)
        {

            var number = new[] { 2,5,6,8,9,10,1,5};
            
            //lenght
            
            Console.WriteLine("Length: " + number.Length);
            
            //Index of
            Console.WriteLine(" Index Of: " + Array.IndexOf(number,10));

            //clear
            Array.Clear(number, 0, 2);
            Console.WriteLine("Effect of clear:");
            foreach( var i in number)
            {
                Console.WriteLine(i);
            }

            //copy
            int[] another = new int[5];
            Array.Copy(number, another, 5);
            Console.WriteLine("Copy array: ");
            foreach (var i in another)
            {
                Console.WriteLine(i);
            }

            //sort

            Array.Sort(number);
            Console.WriteLine("Soring Effect:");
            foreach(var i in number)
                Console.WriteLine(i);
            Array.Reverse(number);

        }
    }
}
