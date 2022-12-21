using System;
using System.Collections.Generic;

namespace Problem_4._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int p = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(p)) numbers[p] = 0;
                numbers[p]++;
            }
            foreach (var num in numbers)
            {
                if (num.Value % 2 == 0) Console.WriteLine(num.Key);
            }
        }
    }
}
