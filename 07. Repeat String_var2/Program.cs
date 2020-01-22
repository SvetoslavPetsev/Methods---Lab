using System;

namespace _07._Repeat_String_var2
{
    class Program
    {
        private static string RepeatString(string a, int b)
        {
            string result = "";
            for (int i = 0; i < b; i++)
            {
                result += a;
            }
            return result;
        }
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int numberRepeat = int.Parse(Console.ReadLine());
            string newString = RepeatString(inputString, numberRepeat);
            Console.WriteLine(newString);
        }
    }
}
