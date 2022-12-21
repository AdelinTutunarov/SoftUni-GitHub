using System;

namespace P1._Action_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Action<string[]> print = (names) => Console.WriteLine(string.Join(Environment.NewLine, names));
            print(names);
        }
    }
}
