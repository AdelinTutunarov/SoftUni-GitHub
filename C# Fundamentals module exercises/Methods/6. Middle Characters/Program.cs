using System;

namespace _6._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMidCharr(input);
        }

        static void PrintMidCharr(string a)
        {
            char[] arr = new char[a.Length];
            arr = a.ToCharArray();
            if (a.Length % 2 == 0) Console.WriteLine($"{arr[a.Length / 2 - 1]}{arr[a.Length / 2]}");
            else Console.WriteLine(arr[a.Length / 2]);
        }
    }
}
