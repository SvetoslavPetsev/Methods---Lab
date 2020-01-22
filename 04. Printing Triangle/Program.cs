using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void PrintI(int number)
        {
            Console.Write(number + " ");
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    PrintI(j);
                }
                Console.WriteLine();
            }
            for (int i = number - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    PrintI(j);
                }
                Console.WriteLine();
            }
        }
    }
}
