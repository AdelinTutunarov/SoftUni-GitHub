using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @">>(?<name>[A-Za-z]+)<<(?<price>\d+(.\d+)?)!(?<count>\d+)";
            var furnitures = new List<string>();
            double totalPrice = 0;
            while (input != "Purchase")
            {
                Match matches = Regex.Match(input, regex);
                if (matches.Success)
                {
                    totalPrice = totalPrice + (double.Parse(matches.Groups["price"].Value) * int.Parse(matches.Groups["count"].Value));
                    furnitures.Add(matches.Groups["name"].Value);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            foreach (var furniture in furnitures)
            {
                Console.WriteLine(furniture);
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
