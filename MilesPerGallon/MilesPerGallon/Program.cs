using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many miles have you driven? ");
            int miles = int.Parse(Console.ReadLine());
            Console.Write("How many gallons of gas have been used? ");
            int gasGallons = int.Parse(Console.ReadLine());
            int MPG = miles / gasGallons;
            Console.WriteLine("You drove " + MPG + " miles-per-gallons.");
            Console.ReadLine();
        }
    }
}
