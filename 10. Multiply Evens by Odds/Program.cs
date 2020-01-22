using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static int GetSumEven(string number)
        {
            int sumEven = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] != '-')
                {
                    int a = number[i] - '0';
                    if (a % 2 == 0)
                    {
                        sumEven += a;
                    }
                }
            }
            return sumEven;
        }
        static int GetSumOdd(string number)
        {
            int sumOdd = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] != '-')
                {
                    int a = number[i] - '0';
                    if (a % 2 != 0)
                    {
                        sumOdd += a;
                    }
                }
            }
            return sumOdd;
        }

        static void Main()
        {
            string inputNumber = Console.ReadLine();

            int sumEven = GetSumEven(inputNumber);
            int sumOdd = GetSumOdd(inputNumber);
            int multiply = sumEven * sumOdd;
            Console.WriteLine(multiply);
        }
    }
}
