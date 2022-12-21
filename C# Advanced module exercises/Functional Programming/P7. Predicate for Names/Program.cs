using System;

namespace P7._Predicate_for_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nameLength = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Action<string[], Predicate<string>> print = (names, match) =>
            {
                foreach (var name in names)
                {
                    if (match(name)) Console.WriteLine(name);
                }
            };
            print(names, name => name.Length <= nameLength);
        }
    }
}
