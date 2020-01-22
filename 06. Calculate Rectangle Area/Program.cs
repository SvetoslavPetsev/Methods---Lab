using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static double CalculateRectangleArea(double a, double b)
        {
            return a * b;
        }
        static void Main()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            Console.WriteLine(CalculateRectangleArea(sideA, sideB));
        }
    }
}
