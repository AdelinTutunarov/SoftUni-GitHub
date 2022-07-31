using System;
using System.Collections.Generic;

namespace _3._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var prices = new Dictionary<string, double>();
            var bill = new Dictionary<string, int>();
            string[] command = Console.ReadLine().Split();
            while (command[0] != "buy")
            {
                prices[command[0]] = double.Parse(command[1]);
                if (!bill.ContainsKey(command[0])) bill[command[0]] = 0;
                bill[command[0]] += int.Parse(command[2]);
                
                command = Console.ReadLine().Split();
            }
            foreach (var i in bill)
            {
                foreach (var t in prices)
                {
                    if(i.Key == t.Key) Console.WriteLine($"{i.Key} -> {i.Value * t.Value:f2}");
                }
            }
        }
    }
}
