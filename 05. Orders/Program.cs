using System;

namespace _05._Orders
{
    class Program
    {
        static double PrintSum(double a, int b)
        {
            double paySum = a * b;
            return paySum;
        }
        static void Main()
        {
            string drinkName = Console.ReadLine();
            int numberOfDrinks = int.Parse(Console.ReadLine());
            double price = 0;
            switch (drinkName)
            {
                case "coffee":
                    price = 1.50;
                    break;
                case "water":
                    price = 1.00;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;
            }
            double sum = PrintSum(price, numberOfDrinks);
            Console.WriteLine($"{sum:F2}");
        }
    }
}
