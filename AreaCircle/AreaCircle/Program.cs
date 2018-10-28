using System;

namespace AreaCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius: ");
            double r = double.Parse(Console.ReadLine());
            double area = (r * r) * 3.14;

            if (r < 0)
            {
                string message = "Error";
                Console.WriteLine(message);
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("Area = " + area);
            Console.ReadLine();
        }
    }
}   
