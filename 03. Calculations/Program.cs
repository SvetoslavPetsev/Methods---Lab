using System;

namespace _03._Calculations
{
    class Program
    {
        static double Add(double a, double b)
        {
            double calculation = a + b;
            return calculation;
        }

        static double Multiply(double a, double b)
        {
            double calculation = a * b;
            return calculation;
        }

        static double Subtract(double a, double b)
        {
            double calculation = a - b;
            return calculation;
        }

        static double Divide(double a, double b)
        {
            double calculation = a / b;
            return calculation;
        }

        static void Main()
        {
            string comand = Console.ReadLine();
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double result = 0;
            switch (comand)
            {
                case "add":
                   result = Add(a, b);
                    break;
                case "multiply":
                    result = Multiply(a, b);
                    break;
                case "subtract":
                    result = Subtract(a, b);
                    break;
                case "divide":
                    result = Divide(a, b);
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
