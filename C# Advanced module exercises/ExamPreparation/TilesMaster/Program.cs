using System;
using System.Collections.Generic;
using System.Linq;

namespace TilesMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> kitchen = new Dictionary<string, int>();
            kitchen.Add("Countertop", 0);
            kitchen.Add("Floor", 0);
            kitchen.Add("Oven", 0);
            kitchen.Add("Sink", 0);
            kitchen.Add("Wall", 0);
            Stack<int> whiteTiles = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> greyTiles = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            while (whiteTiles.Count > 0 && greyTiles.Count > 0)
            {
                int lastWhite = whiteTiles.Pop();
                int firstGray = greyTiles.Dequeue();
                if (lastWhite == firstGray)
                {
                    switch (lastWhite + firstGray)
                    {
                        case 40:
                            kitchen["Sink"]++;
                            break;
                        case 50:
                            kitchen["Oven"]++;
                            break;
                        case 60:
                            kitchen["Countertop"]++;
                            break;
                        case 70:
                            kitchen["Wall"]++;
                            break;
                        default:
                            kitchen["Floor"]++;
                            break;
                    }
                }
                else
                {
                    whiteTiles.Push(lastWhite / 2);
                    greyTiles.Enqueue(firstGray);
                }
            }
            kitchen = kitchen.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            if (whiteTiles.Count > 0) Console.WriteLine($"White tiles left: {string.Join(", ", whiteTiles)}");
            else Console.WriteLine("White tiles left: none");
            if (greyTiles.Count > 0) Console.WriteLine($"Grey tiles left: {string.Join(", ", greyTiles)}");
            else Console.WriteLine("Grey tiles left: none");
            foreach (var item in kitchen)
            {
                if (item.Value > 0) Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
