using System;
using System.Linq;

namespace _6._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ").ToArray();
            int[] integerarr = new int[arr.Length];
            int sum1 = 0, sum2 =0, index = 0;
            bool check = false;
            for (int i = 0; i < arr.Length; i++)
            {
                integerarr[i] = int.Parse(arr[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if(i != 0) sum1 += integerarr[i - 1];
                for (int j = i+1; j < arr.Length; j++)
                {
                    sum2 += integerarr[j];
                }
                if (sum1 == sum2)
                {
                    index = i;
                    check = true;
                    break;
                }
                else sum2 = 0;
            }
            if (!check) Console.WriteLine("no");
            else Console.WriteLine(index);
        }
    }
}
