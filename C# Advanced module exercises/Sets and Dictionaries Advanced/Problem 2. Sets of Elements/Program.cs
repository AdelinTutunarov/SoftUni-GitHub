using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> numbers1 = new HashSet<int>();
            HashSet<int> numbers2 = new HashSet<int>();
            for (int i = 0; i < nm[0] + nm[1]; i++)
            {
                if (i < nm[0]) numbers1.Add(int.Parse(Console.ReadLine()));
                else numbers2.Add(int.Parse(Console.ReadLine()));
            }
            foreach (var num in numbers1)
            {
                if (numbers2.Contains(num)) Console.Write($"{num} ");
            }
        }
    }
}
