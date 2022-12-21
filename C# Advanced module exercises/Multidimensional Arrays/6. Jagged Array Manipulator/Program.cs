using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jaggedArr = new double[n][];
            for (int i = 0; i < n; i++)
            {
                double[] input = Console.ReadLine().
                    Split(' ', StringSplitOptions.RemoveEmptyEntries).
                    Select(double.Parse).ToArray();
                jaggedArr[i] = input;
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (jaggedArr[i].Length == jaggedArr[i + 1].Length)
                {
                    for (int j = 0; j < jaggedArr[i].Length; j++)
                    {
                        jaggedArr[i][j] *= 2;
                        jaggedArr[i + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < jaggedArr[i].Length; j++)
                    {
                        jaggedArr[i][j] /= 2;
                    }
                    for (int j = 0; j < jaggedArr[i + 1].Length; j++)
                    {
                        jaggedArr[i + 1][j] /= 2;
                    }
                }
            }
            string command = Console.ReadLine();
            while (command !="End")
            {
                string[] cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (cmd[0] == "Add")
                {
                    if (int.Parse(cmd[1])>=0 &&
                        int.Parse(cmd[1])<n &&
                        int.Parse(cmd[2])>=0 &&
                        int.Parse(cmd[2])< jaggedArr[int.Parse(cmd[1])].Length)
                    {
                        jaggedArr[int.Parse(cmd[1])][int.Parse(cmd[2])] += double.Parse(cmd[3]);
                    }
                }else if (cmd[0]== "Subtract")
                {
                    if (int.Parse(cmd[1]) >= 0 &&
                        int.Parse(cmd[1]) < n &&
                        int.Parse(cmd[2]) >= 0 &&
                        int.Parse(cmd[2]) < jaggedArr[int.Parse(cmd[1])].Length)
                    {
                        jaggedArr[int.Parse(cmd[1])][int.Parse(cmd[2])] -= double.Parse(cmd[3]);
                    }
                }

                command = Console.ReadLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.Write($"{jaggedArr[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
