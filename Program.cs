using System;

namespace HelloWorld
{
    public class Program
    {
      static void Main(string[] args)
        {
            Console.Write("Enter our First Name: ");
            var fName = Console.ReadLine();
            Console.Write("Enter our Last Name: ");
            var lName = Console.ReadLine();
            Console.WriteLine("Hello " + fName + lName);
            //Console.WriteLine("Hello Usen!");
            //Console.WriteLine("Hello Nsisong!");
            //Console.WriteLine("Hello World!");
        }
    }
}
