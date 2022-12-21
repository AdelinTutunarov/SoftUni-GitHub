using System;
using System.Linq;

namespace P3._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Func<int[], int> min = (nums) =>
            {
                int min = int.MaxValue;
                foreach (var num in nums)
                {
                    if (min > num) min = num;
                }
                return min;
            };
            Console.WriteLine(min(arr));
        }
    }
}
