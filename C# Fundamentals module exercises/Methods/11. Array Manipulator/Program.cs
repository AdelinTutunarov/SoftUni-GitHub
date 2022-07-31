using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string[] command;
            do
            {
                command = Console.ReadLine().Split();
                if (command[0] == "exchange")
                {
                    if (int.Parse(command[1]) >= arr.Length || int.Parse(command[1]) < 0) Console.WriteLine("Invalid index");
                    else
                    {
                        arr = ExchangeArr(arr, int.Parse(command[1]));
                    }
                }
                else if (command[0] == "max")
                {
                    if (command[1] == "even") FindMaxEven(arr);
                    else if (command[1] == "odd") FindMaxOdd(arr);
                }
                else if (command[0] == "min")
                {
                    if (command[1] == "even") FindMinEven(arr);
                    else if (command[1] == "odd") FindMinOdd(arr);
                }
                else if (command[0] == "first")
                {
                    if (int.Parse(command[1]) > arr.Length || int.Parse(command[1]) < 0) Console.WriteLine("Invalid count");
                    else
                    {
                        if (command[2] == "even") FindFistEven(arr, int.Parse(command[1]));
                        else if (command[2] == "odd") FindFirstOdd(arr, int.Parse(command[1]));
                    }
                }
                else if (command[0] == "last")
                {
                    if (int.Parse(command[1]) > arr.Length || int.Parse(command[1]) < 0) Console.WriteLine("Invalid count");
                    else
                    {
                        if (command[2] == "even") FindLastEven(arr, int.Parse(command[1]));
                        else if (command[2] == "odd") FindLastOdd(arr, int.Parse(command[1]));
                    }
                }

            } while (command[0] != "end");

            PrintArr(arr, arr.Length);
        }

        private static void FindLastOdd(int[] arr, int v)
        {
            int[] lastOddNums = new int[v];
            int count = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 == 1)
                {
                    
                    for (int j = count - 1; j >= 0; j--)
                    {
                        lastOddNums[j + 1] = lastOddNums[j];
                    }
                    lastOddNums[0] = arr[i];
                    count++;
                    if (count == v) break;
                }
            }
            PrintArr(lastOddNums, count);
        }

        private static void FindLastEven(int[] arr, int v)
        {
            int[] lastEvenNums = new int[v];
            int count = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 == 0)
                {
                    for (int j = count - 1; j >= 0; j--)
                    {
                        lastEvenNums[j + 1] = lastEvenNums[j];
                    }
                    lastEvenNums[0] = arr[i];
                    count++;
                    if (count == v) break;
                }
            }
            PrintArr(lastEvenNums, count);
        }

        private static void FindFirstOdd(int[] arr, int v)
        {
            int[] firstOddNums = new int[v];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    firstOddNums[index] = arr[i];
                    index++;
                    if (index == v) break;
                }
            }
            PrintArr(firstOddNums, index);
        }

        private static void FindFistEven(int[] arr, int v)
        {
            int[] firstEvenNums = new int[v];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    firstEvenNums[index] = arr[i];
                    index++;
                    if (index == v) break;
                }
            }
            PrintArr(firstEvenNums, index);
        }

        private static void FindMinOdd(int[] arr)
        {
            int min = arr[0], index = 0;
            bool check = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    check = true;
                    if (arr[i] <= min)
                    {
                        min = arr[i];
                        index = i;
                    }

                }
            }
            if (check)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void FindMinEven(int[] arr)
        {
            int min = arr[0], index = 0;
            bool check = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    check = true;
                    if (arr[i] <= min)
                    {
                        min = arr[i];
                        index = i;
                    }

                }
            }
            if (check)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void FindMaxOdd(int[] arr)
        {
            int max = arr[0], index = 0;
            bool check = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    check = true;
                    if (arr[i] >= max)
                    {
                        max = arr[i];
                        index = i;
                    }

                }
            }
            if (check)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void FindMaxEven(int[] arr)
        {
            int max = arr[0], index = 0;
            bool check = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    check = true;
                    if (arr[i] >= max)
                    {
                        max = arr[i];
                        index = i;
                    }

                }
            }
            if (check)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static int[] ExchangeArr(int[] arr, int n)
        {
            int[] newArr = new int[arr.Length];
            int index = 0;
            for (int i = n + 1; i < arr.Length; i++)
            {
                newArr[index] = arr[i];
                index++;
            }
            for (int i = 0; i <= n; i++)
            {
                newArr[index] = arr[i];
                index++;
            }
            return newArr;
        }

        private static void PrintArr(int[] arr, int n)
        {
            Console.Write("[");
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{arr[i]}");
                    if (i != n - 1) Console.Write(", ");
                }
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}
