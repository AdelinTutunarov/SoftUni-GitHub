using System;
using System.Linq;

namespace _5._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ").ToArray();
            bool[] check = new bool[arr.Length];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (int.Parse(arr[i]) > int.Parse(arr[j]))
                    {
                        check[i] = true;
                    }
                    else
                    {
                        check[i] = false;
                        break;
                    }
                }
            }
            check[arr.Length - 1] = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (check[i]) Console.Write($"{arr[i]} ");
            }
        }
    }
}
