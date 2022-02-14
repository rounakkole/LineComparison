// See https://aka.ms/new-console-template for more information
using System;

namespace LineComparison
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Output();
        }

        public static int Compare()
        {
            Line line1 = new Line();
            Line line2 = new Line();
            double length1 = line1.GetLength();
            double length2 = line2.GetLength();
            int result = length1.CompareTo(length2);
            return result;
        }

        public static void Output()
        {
            int result = Compare();
            switch (result)
            {
                case 1:
                    Console.WriteLine("line1 is greater than line2");
                    break;
                case -1:
                    Console.WriteLine("line1 is less than line2");
                    break;
                default:
                    Console.WriteLine("line1 is equal to line2");
                    break;
            }
        }
    }
}
