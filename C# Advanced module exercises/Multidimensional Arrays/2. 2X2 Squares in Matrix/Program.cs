using System;
using System.Linq;

namespace _2._2X2_Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = rowsAndCols[0], cols = rowsAndCols[1], counter = 0;
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                char[] input = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            if (rows > 1 && cols > 1)
            {
                for (int i = 0; i < rows - 1; i++)
                {
                    for (int j = 0; j < cols - 1; j++)
                    {
                        if (matrix[i, j] == matrix[i + 1, j] && matrix[i, j] == matrix[i, j + 1] && matrix[i, j] == matrix[i + 1, j + 1]) counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
