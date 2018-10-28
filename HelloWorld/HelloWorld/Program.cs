using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your name: ");
            string  myName = Console.ReadLine();
            Console.WriteLine("Hello, " + myName + "!");
            Console.ReadLine();
        }
    }
}
