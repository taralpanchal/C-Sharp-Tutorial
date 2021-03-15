using System;

using System.IO;
using System.Text;


namespace Hello_World
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Enter num1 :");
            var num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter Num2 : ");
            var num2 = Convert.ToInt32(Console.ReadLine());

           var max = (num1 > num2) ? num1 : num2;
            Console.WriteLine(max);
        }
    }
}
  
