using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] powern = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == powern[0])
                {
                    for (int j = Math.Max(0 , i - powern[1]); j <= Math.Min(numbers.Count - 1, i + powern[1]); j++)
                    {
                        numbers[j] = 0;
                    }
                }
            }
            foreach (int i in numbers)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
