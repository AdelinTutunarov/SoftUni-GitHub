using System;
using System.Collections.Generic;
using System.Linq;

namespace P8._List_of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] numbers = Enumerable.Range(1, n).ToArray();
            List<Predicate<int>> predicates = new List<Predicate<int>>();
            foreach (var divider in dividers)
            {
                predicates.Add(x => x % divider == 0);
            }
            foreach (var number in numbers)
            {
                bool check = true;
                foreach (var predicate in predicates)
                {
                    if (!predicate(number))
                    {
                        check = false;
                        break;
                    }
                }
                if (check) Console.Write($"{number} ");
            }
        }
    }
}
