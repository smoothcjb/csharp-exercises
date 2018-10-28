using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Console.Write("Enter the length: ");
            int L = int.Parse(Console.ReadLine());
            Console.Write("Enter the width: ");
            int W = int.Parse(Console.ReadLine());
            int area = (L * W);
            Console.WriteLine("Area = " + area);
            Console.ReadLine();

        }
    }
}
