using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] tokens = command.Split();
                if(tokens.Length == 2)
                {
                    wagons.Add(int.Parse(tokens[1]));
                }
                else
                {
                    FindWagon(wagons, capacity, int.Parse(tokens[0]));
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }

        private static void FindWagon(List<int> wagons, int capacity, int passengers)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
                if (wagons[i] + passengers <= capacity)
                {
                    wagons[i] += passengers;
                    break;
                }
            }
        }
    }
}
