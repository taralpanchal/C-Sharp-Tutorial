﻿using System;

using System.IO;
using System.Text;


namespace Hello_World
{
    class Program
    {

        static void Main(string[] args)
        {
            //3 - Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.



            Console.Write("Enter Number:-");
            var number = Convert.ToInt32(Console.ReadLine());

             int ans=1;
            for (int i=1; i<=number; i++)
            {
                
                ans = ans * i;
            }
            Console.WriteLine("FAct No is:-" + ans);
        }
    }
}
  
