﻿using System;


namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)

        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a : {0} , b : {1}",a ,b));

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array[0] : {0}, array[0] : {1}",array1[1],array2[1]));
            Console.WriteLine(array1[0]);
            Console.WriteLine(array1[1]);
            Console.WriteLine(array1[2]);
        }

    }
}
