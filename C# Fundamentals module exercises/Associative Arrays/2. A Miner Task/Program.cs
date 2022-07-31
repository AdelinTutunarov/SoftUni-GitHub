using System;
using System.Collections.Generic;

namespace _2._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, int>();
            int quantity;
            string command = Console.ReadLine();
            while (command != "stop")
            {
                if (!resources.ContainsKey(command)) resources[command] = 0;
                quantity = int.Parse(Console.ReadLine());
                resources[command] += quantity;
                command = Console.ReadLine();
            }
            foreach (var i in resources) Console.WriteLine($"{i.Key} -> {i.Value}");
        }
    }
}
