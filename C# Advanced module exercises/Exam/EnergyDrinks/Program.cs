using System;
using System.Collections.Generic;
using System.Linq;

namespace EnergyDrinks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> caffeine = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> energyDrinks = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            double drankCaffeinе = 0;
            while (caffeine.Count > 0 && energyDrinks.Count > 0)
            {
                int lastCaffeinе = caffeine.Pop();
                int firstEnergyDrink = energyDrinks.Dequeue();
                int totalCaffeinе = lastCaffeinе * firstEnergyDrink;
                if (totalCaffeinе + drankCaffeinе <= 300) drankCaffeinе += totalCaffeinе;
                else
                {
                    energyDrinks.Enqueue(firstEnergyDrink);
                    if (drankCaffeinе < 30) drankCaffeinе = 0;
                    else drankCaffeinе -= 30;
                }
            }
            if (energyDrinks.Count > 0) Console.WriteLine($"Drinks left: {string.Join(", ", energyDrinks)}");
            else Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
            Console.WriteLine($"Stamat is going to sleep with {drankCaffeinе} mg caffeine.");
        }
    }
}
