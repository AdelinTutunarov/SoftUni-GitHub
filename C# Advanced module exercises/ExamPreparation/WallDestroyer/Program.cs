using System;

namespace WallDestroyer
{
    internal class Program
    {
        private static int holeCounter = 1;
        private static int rodHitTimes = 0;
        private static int n;
        private static int[] position;
        private static char[,] matrix;
        private static bool isAlive = true;
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            matrix = new char[n, n];
            position = new int[2] { 0, 0 };
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = input[j];
                    if (input[j] == 'V')
                    {
                        position[0] = i;
                        position[1] = j;
                    }
                }
            }
            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "End") break;
                switch (cmd)
                {
                    case "up":
                        Move(-1, 0);
                        break;
                    case "down":
                        Move(1, 0);
                        break;
                    case "left":
                        Move(0, -1);
                        break;
                    case "right":
                        Move(0, 1);
                        break;
                    default:
                        break;
                }
                if (!isAlive) break;
            }
            if(isAlive) Console.WriteLine($"Vanko managed to make {holeCounter} hole(s) and he hit only {rodHitTimes} rod(s).");
            Print(n);
        }

        private static void Move(int row, int col)
        {
            if (IsValidPosition(position[0] + row, position[1] + col))
            {
                switch (matrix[position[0] + row,position[1] + col])
                {
                    case 'C':
                        matrix[position[0], position[1]] = '*';
                        holeCounter++;
                        position[0] += row;
                        position[1] += col;
                        matrix[position[0], position[1]] = 'E';
                        Console.WriteLine($"Vanko got electrocuted, but he managed to make {holeCounter} hole(s).");
                        isAlive = false;
                        break;
                    case 'R':
                        rodHitTimes++;
                        Console.WriteLine($"Vanko hit a rod!");
                        break;
                    case '-':
                        matrix[position[0], position[1]] = '*';
                        holeCounter++;
                        position[0] += row;
                        position[1] += col;
                        matrix[position[0], position[1]] = 'V';
                        break;
                    case '*':
                        matrix[position[0], position[1]] = '*';
                        Console.WriteLine($"The wall is already destroyed at position [{position[0] + row}, {position[1] + col}]!");
                        position[0] += row;
                        position[1] += col;
                        matrix[position[0], position[1]] = 'V';
                        break;
                    default:
                        break;
                }
            }
        }

        private static bool IsValidPosition(int v1, int v2)
        {
            return v1 >= 0 && v1 < matrix.GetLength(0) && v2 >= 0 && v2 < matrix.GetLength(1);
        }

        private static void Print(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
