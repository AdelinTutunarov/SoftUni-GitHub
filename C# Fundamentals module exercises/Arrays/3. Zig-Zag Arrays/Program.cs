using System;
using System.Linq;

namespace _3._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] arr2d = new int[2,n];
            string[] p = new string[2];
            bool check = false;
            for (int i = 0; i < n; i++)
            {
                p = Console.ReadLine().Split(" ").ToArray();
                if (check)
                {
                    arr2d[1, i] = int.Parse(p[0]);
                    arr2d[0, i] = int.Parse(p[1]);
                    check = false;
                }
                else
                {
                    arr2d[0, i] = int.Parse(p[0]);
                    arr2d[1, i] = int.Parse(p[1]);
                    check = true;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{arr2d[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
