using System;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            var timeOfDay = TimeChecker.TimeOfDay();
            Console.Write("Enter Your First Name: ");
            var fName = Console.ReadLine();
            Console.Write("Enter Your Last Name: ");
            var lName = Console.ReadLine();
            Console.WriteLine("Good " + timeOfDay +" "+ fName + " " + lName + "!!!");
        }
    }
}
