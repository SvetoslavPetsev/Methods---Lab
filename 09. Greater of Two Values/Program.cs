using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static string GetBestString(string str1, string str2)
        {
            if (str1.CompareTo(str2) >= 0)
            {
                return str1;
            }
            else
            {
                return str2;
            }
        }
        static char GetBestChar(char a, char b)
        {
            char bestChar = a;
            if (b > a)
            {
                return bestChar = b;
            }
            else
            {
                return bestChar = a;
            }
        }

        static int GetBestInt(int a, int b)
        {
            int bestInt = a;
            if (b > a)
            {
                return bestInt = b;
            }
            else
            {
                return bestInt = a;
            }
        }
        static void Main()
        {
            string inputType = Console.ReadLine();
            switch (inputType)
            {
                case "int":
                    int c = int.Parse(Console.ReadLine());
                    int d = int.Parse(Console.ReadLine());
                    int bestInt = GetBestInt(c, d);
                    Console.WriteLine(bestInt);
                    break;
                case "char":
                    char e = char.Parse(Console.ReadLine());
                    char f = char.Parse(Console.ReadLine());
                    char bestChar = GetBestChar(e, f);
                    Console.WriteLine(bestChar);
                    break;
                default:
                    string a = Console.ReadLine();
                    string b = Console.ReadLine();
                    string best = GetBestString(a, b);
                    Console.WriteLine(best);
                    break;
            }
        }
    }
}
