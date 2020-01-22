using System;

namespace _05._Orders_var2
{
    class Program
    {
        static void PrintSum(double a, int b)
        {
            Console.WriteLine($"{(a * b):F2}");
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
            PrintSum(price, numberOfDrinks);
        }
    }
}
