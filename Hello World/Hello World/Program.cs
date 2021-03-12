using System;
using System.Collections.Generic;

namespace Hello_World
{
    class Program
    {

        static void Main(string[] args)
        {
            //add element
            var number = new List<int> () {2,5,6,8,9,10,1,5};
            number.Add(1); 
           
            //Add Range 
            number.AddRange(new int[] { 10, 12, 13 });
            foreach(var i in number)
            {
                Console.WriteLine(i);
            }

            
            Console.WriteLine("index of 10: " + number.IndexOf(5));
            //count number
            Console.WriteLine("Count: "+number.Count);
            //Index
            Console.WriteLine("Last Index:"+number.LastIndexOf(10));

            //remove
            number.Remove(5);
        
            foreach(var i in number)
                Console.WriteLine(i);

           //clear list
           number.Clear();
        }
    }
}
