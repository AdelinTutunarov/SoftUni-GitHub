using System;
using System.Collections.Generic;
using System.Linq;

namespace P6._Reverse_and_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int a = int.Parse(Console.ReadLine());
            Predicate<int> isDevisable = x => x % a == 0;
            Func<List<int>, List<int>> removeDevisable = (list) =>
            {
                List<int> result = new List<int>();
                foreach (var num in list)
                {
                    if(!isDevisable(num)) result.Add(num);
                }
                return result;
            };
            Func<List<int>, List<int>> reverseList = (list) =>
            {
                List<int> result = new List<int>();
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    result.Add(list[i]);
                }
                return result;
            };
            ints = removeDevisable(ints);
            ints = reverseList(ints);
            Console.WriteLine(string.Join(" ", ints));
        }
    }
}
