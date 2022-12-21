using System;
using System.Collections.Generic;

namespace Problem_6._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,Dictionary<string,int>> wardrobe = new Dictionary<string,Dictionary<string,int>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];
                if (!wardrobe.ContainsKey(color)) wardrobe.Add(color, new Dictionary<string,int>());
                for (int j = 1; j < input.Length; j++)
                {
                    if (!wardrobe[color].ContainsKey(input[j])) wardrobe[color][input[j]] = 0;
                    wardrobe[color][input[j]]++;
                }
            }
            string[] itemToFind = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var item in color.Value)
                {
                    string printItem = $"* {item.Key} - {item.Value}";
                    if (color.Key == itemToFind[0] && item.Key == itemToFind[1]) printItem += " (found!)";
                    Console.WriteLine(printItem);
                }
            }
        }
    }
}
