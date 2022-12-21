using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[dimensions[0], dimensions[1]];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            string[] cmd = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (cmd[0] != "END")
            {
                if (cmd[0] == "swap" &&
                    cmd.Length == 5 &&
                    int.Parse(cmd[1]) >= 0 && int.Parse(cmd[1]) < matrix.GetLength(0) &&
                    int.Parse(cmd[2]) >= 0 && int.Parse(cmd[2]) < matrix.GetLength(1) &&
                    int.Parse(cmd[3]) >= 0 && int.Parse(cmd[3]) < matrix.GetLength(0) &&
                    int.Parse(cmd[4]) >= 0 && int.Parse(cmd[4]) < matrix.GetLength(1))
                {
                    int p = matrix[int.Parse(cmd[1]), int.Parse(cmd[2])];
                    matrix[int.Parse(cmd[1]), int.Parse(cmd[2])] = matrix[int.Parse(cmd[3]), int.Parse(cmd[4])];
                    matrix[int.Parse(cmd[3]), int.Parse(cmd[4])] = p;
                    Print(matrix);
                }
                else Console.WriteLine("Invalid input!");

                cmd = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
        }
        private static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
