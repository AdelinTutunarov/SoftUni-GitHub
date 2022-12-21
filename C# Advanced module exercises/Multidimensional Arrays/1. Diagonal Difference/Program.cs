using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int primaryDiagonal = 0, secondaryDiagonal = 0;
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = numbers[j];
                    if (i == j) primaryDiagonal += matrix[i, j];
                    if (i == n - j - 1) secondaryDiagonal += matrix[i, j];
                }
            }
            Console.WriteLine(Math.Max(primaryDiagonal, secondaryDiagonal) - Math.Min(primaryDiagonal, secondaryDiagonal));
        }
    }
}
