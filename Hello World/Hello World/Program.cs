using System;
using System.Collections.Generic;
using System.Text;


namespace Hello_World
{
    class Program
    {

        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            builder.Append('*', 10)
                .AppendLine()
                .AppendLine()
                .Append('*', 10)
                .Insert(5, "@", 3)
                .Replace("@", "$")
                .Remove(5, 3)
                .Clear()
                .Append("Header");
            Console.WriteLine(builder);
        }
        
    }
}
