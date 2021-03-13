using System;
using System.Collections.Generic;


namespace Hello_World
{
    class Program
    {

        static void Main(string[] args)
        {
            string sentence = "This is realy realy realy long Text ";
            var summary = StringUtility.SummerizeText(sentence, 25);
            Console.WriteLine(summary);
        }
        
    }
}
