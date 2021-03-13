using System;


namespace Hello_World
{
    class Program
    {

        static void Main(string[] args)
        {
            var fullname = "Mosh Hamedani Mosh ";

            Console.WriteLine("Last Index of :" + fullname.LastIndexOf("M"));

            var index = fullname.IndexOf(' ');
            Console.WriteLine("index of:"+index);
            Console.WriteLine(fullname.Substring(0, index));

            Console.WriteLine(fullname.Substring(index+1));

            Console.WriteLine("Replace : " +fullname.Replace("Mosh", "Moshhh")); 

            var name = fullname.Split(" ");
            Console.WriteLine("FirstName :" +name[0]);
            Console.WriteLine("LastName :" +name[1]);
             
            var str = 'a';
            Console.WriteLine(Convert.ToByte(str));

            Console.WriteLine("Trim: '{0}'" ,fullname.Trim()); //{0} Placeholder
            
            Console.WriteLine("Upper: '{0}','{1}'" ,fullname.Trim().ToUpper(), fullname);

            float price = 19.50f;
            Console.WriteLine(price.ToString("c"));

                
        }

       
    }
}
