using System;

namespace _1._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), passengers = 0;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                passengers += arr[i];
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine(passengers);
        }
    }
}
