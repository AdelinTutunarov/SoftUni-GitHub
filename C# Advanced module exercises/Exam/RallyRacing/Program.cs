using System;
using System.Linq;

namespace RallyRacing
{
    internal class Program
    {
        private static int n;
        private static string carNumber;
        private static char[,] matrix;
        private static int[] position;
        private static bool isDisqualified;
        private static bool isFinished;
        private static int coveredDistance = 0;

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            carNumber = Console.ReadLine();
            matrix = new char[n, n];
            position = new int[2] { 0, 0 };
            isDisqualified = false;
            isFinished = false;

            for (int i = 0; i < n; i++)
            {
                char[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            while (true)
            {
                string cmd = Console.ReadLine().ToLower();
                if (cmd == "end")
                {
                    isDisqualified = true;
                    break;
                }
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
                if (isFinished) break;
            }
            matrix[position[0], position[1]] = 'C';
            if (isFinished) Console.WriteLine($"Racing car {carNumber} finished the stage!");
            if (isDisqualified) Console.WriteLine($"Racing car {carNumber} DNF.");
            Console.WriteLine($"Distance covered {coveredDistance} km.");
            Print();
        }

        private static void Print()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }

        private static void Move(int row, int col)
        {
            switch (matrix[position[0] + row, position[1] + col])
            {
                case '.':
                    position[0] += row;
                    position[1] += col;
                    coveredDistance += 10;
                    break;
                case 'T':
                    matrix[position[0] + row, position[1] + col] = '.';
                    FindTheOtherT();
                    coveredDistance += 30;
                    break;
                case 'F':
                    coveredDistance += 10;
                    position[0] += row;
                    position[1] += col;
                    isFinished = true;
                    break;
                default:
                    break;
            }
        }

        private static void FindTheOtherT()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == 'T')
                    {
                        matrix[i, j] = '.';
                        position[0] = i;
                        position[1] = j;
                    }
                }
            }
        }
    }
}
