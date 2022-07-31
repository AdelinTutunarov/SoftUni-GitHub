using System;

namespace _3._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            CharactersinRange(a, b);
        }

        static void CharactersinRange(char a, char b)
        {
            int firstChar = Math.Min(a, b);
            int lastChar = Math.Max(a, b);
            for (int i = firstChar + 1; i < lastChar; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
