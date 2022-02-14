// See https://aka.ms/new-console-template for more information
using System;

namespace LineComparison
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            bool result = Compare();
            Console.WriteLine($"equality: {result}");
        }

        public static bool Compare()
        {
            Line line1 = new Line();
            Line line2 = new Line();
            double length1 = line1.GetLength();
            double length2 = line2.GetLength();
            bool result = length1.Equals(length2);
            return result;
        }
    }
}
