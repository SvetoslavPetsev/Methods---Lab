using System;

namespace _08._Math_Power
{
    class Program
    {
        static decimal GetPow(double number, double pow)
        {
            decimal result = 0;
            result = Convert.ToDecimal(Math.Pow(number, pow));
            return result;
        }
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());
            Console.WriteLine(GetPow(number, pow));
        }
    }
 }
