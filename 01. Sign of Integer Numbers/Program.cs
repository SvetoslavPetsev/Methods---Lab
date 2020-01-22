using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void PrintSign(int a)
        {
            if (a > 0)
            {
                Console.WriteLine($"The number {a} is positive.");
            }
            else if (a < 0)
            {
                Console.WriteLine($"The number {a} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {a} is zero.");
            }
        }
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintSign(number);
        }
    }
}
