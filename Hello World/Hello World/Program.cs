using System;


namespace Hello_World
{
    class Program
    {
        public class Person
        {
            public int Age;
        }

        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            Person person = new Person() { Age = 30 };
            makeOld(person);
            Console.WriteLine(person.Age);
        }
        public static void Increment( int number)
        {
            number+=10;
        }
        public static void makeOld(Person person)
        {
            person.Age += 10;
        }

    }
}
