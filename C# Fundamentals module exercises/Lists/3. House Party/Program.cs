using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            Operation(guests, numberOfCommands);

        }

        private static void Operation(List<string> guests, int numberOfCommands)
        {
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (command.Length == 3)
                {
                    if (guests.Contains(command[0])) Console.WriteLine($"{command[0]} is already in the list!");
                    else guests.Add(command[0]);
                }
                else
                {
                    if (!guests.Contains(command[0])) Console.WriteLine($"{command[0]} is not in the list!");
                    else guests.Remove(command[0]);
                }
            }
            foreach (string name in guests)
            {
                Console.WriteLine(name);
            }
        }
    }
}
