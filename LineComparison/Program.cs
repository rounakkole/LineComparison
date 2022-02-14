// See https://aka.ms/new-console-template for more information
using System;

namespace LineComparison
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            double length=GetLength();
            Console.WriteLine($"length: {length}");
        }

        public static double GetLength()
        {
            Console.WriteLine("eneter 4 values (x1, y1, x2, y2)");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            double length = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)));
            return length;
        }



    }
}
