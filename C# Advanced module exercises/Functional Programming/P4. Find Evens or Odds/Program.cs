using System;
using System.Linq;

namespace P4._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isOdd = x => x % 2 == 1;
            int[] minMax = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string cmd = Console.ReadLine();
            for (int i = minMax[0]; i <= minMax[1]; i++)
            {
                if (cmd == "odd" && isOdd(i)) Console.Write($"{i} ");
                if (cmd == "even" && !isOdd(i)) Console.Write($"{i} ");
            }
        }
    }
}
