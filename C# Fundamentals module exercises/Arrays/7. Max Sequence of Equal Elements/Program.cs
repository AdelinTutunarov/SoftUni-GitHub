using System;
using System.Linq;

namespace _7._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ").ToArray();
            string p = arr[0];
            int count = 1, checkcount = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                while (i < arr.Length && arr[i - 1] == arr[i])
                {
                    checkcount++;
                    i++;
                }
                if (checkcount > count)
                {
                    count = checkcount;
                    p = arr[i - 1];
                }
                checkcount = 1;
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{p} ");
            }
        }
    }
}
