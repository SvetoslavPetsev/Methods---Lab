using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void RepeatString(string a, int b)
        {
            for (int i = 0; i < b; i++)
            {
                Console.Write(a);
            }
        }
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int numberRepeat = int.Parse(Console.ReadLine());
            RepeatString(inputString, numberRepeat);
        }
    }
}
