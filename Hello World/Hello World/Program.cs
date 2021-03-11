using System;


namespace Hello_World
{
    public class Person
    {
        public string FirstName;
        public string LastName; 
            
        public void Introduse()
        {

            Console.WriteLine("Hi my name is " + FirstName + " " + LastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Taral";
            person.LastName = "Panchal";
            person.Introduse();

            calculator cal = new calculator();
            var result = cal.Add(10,10);
            Console.WriteLine(result);

           
        }
    }
 }
         