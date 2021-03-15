using System;

using System.IO;
using System.Text;


namespace Hello_World
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //4 - Your job is to write a program for a speed camera.For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.Write a program that asks the user to enter the speed limit.Once set, the program asks for the speed of a car.If the user enters a value less than the speed limit, program should display Ok on the console.If the value is above the speed limit, the program should calculate the number of demerit points.For every 5km / hr above the speed limit, 1 demerit points should be incurred and displayed on the console.If the number of demerit points is above 12, the program should display License Suspended.

            Console.WriteLine("Enter Car Speed : ");
            var speed = Convert.ToInt32(Console.ReadLine());

            var speedlimit = 50;
            
            if(speedlimit > speed)
            {
                Console.WriteLine("Ok..!");
            }
            else{
                const int kmperpoint = 5;
                var countpoints = (speed - speedlimit) /kmperpoint; 
                if(countpoints > 12)
                {
                    Console.WriteLine("License Suspended.");
                }
                else
                {
         
                    Console.WriteLine("Your Point : "+countpoints);
                }
            }
        }
    }
}
  
