using System;

namespace _02._Grades
{
    class Program
    {
        static void PrintGrade(double a)
        {
            if (a < 3.00)
            {
                Console.WriteLine("Fail");
            }
            else if (a >= 3 && a < 3.50)
            {
                Console.WriteLine("Poor");
            }
            else if (a >= 3.50 && a < 4.50)
            {
                Console.WriteLine("Good");
            }
            else if (a >= 4.50 && a < 5.50)
            {
                Console.WriteLine("Very good");
            }
            else
            {
                Console.WriteLine("Excellent");
            }
        }
        static void Main()
        {
            double grade = double.Parse(Console.ReadLine());
            PrintGrade(grade);
        }
    }
}
