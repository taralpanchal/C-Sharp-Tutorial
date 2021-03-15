using System;

using System.IO;
using System.Text;


namespace Hello_World
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
                     
            Console.Write("Enter Height: ");
            var Height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Width: ");
            var Width = Convert.ToInt32(Console.ReadLine());
            //if (Height > Width)
            //{
            //    Console.WriteLine("portrait");

            //}
            //else
            //{
            //    Console.WriteLine("landscape");
            //}
            var img = (Height > Width) ? "Portrait" : "landscape";
            Console.WriteLine(img);
        }
    }
}
  
