using System;

using System.IO;
using System.Text;


namespace Hello_World
{
    class Program
    {

        static void Main(string[] args)
        {
            // Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.

            

            int sum = 0;
            while(true)
            {
                Console.Write("Enter Number (break to type Ok) :");
                var input = Console.ReadLine();

                if(input == "ok")
                {
                    break;
                }
                else
                {    
                    sum += Convert.ToInt32(input);
                }
                
            }
            Console.WriteLine("sum of enter number:" +sum);

        }
    }
}
  
