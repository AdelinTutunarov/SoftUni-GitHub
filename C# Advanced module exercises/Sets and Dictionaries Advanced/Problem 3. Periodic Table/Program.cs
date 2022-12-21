using System;
using System.Collections.Generic;

namespace Problem_3._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> elements = new SortedSet<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                foreach (var item in input)
                {
                    elements.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
