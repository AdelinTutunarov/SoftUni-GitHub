using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(", ").ToList();
            var racers = new Dictionary<string, int>();
            string input = Console.ReadLine();
            Regex regexForNames = new Regex(@"(?<name>[A-Za-z]+)");
            Regex regexForDigits = new Regex(@"(?<digits>\d)");
            while (input != "end of race")
            {
                MatchCollection matchedNames = regexForNames.Matches(input);
                MatchCollection matchedDigits = regexForDigits.Matches(input);
                string name = string.Join("", matchedNames);
                int sum = 0;
                foreach (var digit in matchedDigits)
                {
                    sum += int.Parse(digit.ToString());
                }
                if (names.Contains(name))
                {
                    if (!racers.ContainsKey(name)) racers[name] = 0;
                    racers[name] += sum;
                }
                input = Console.ReadLine();
            }
            var winners = racers.OrderByDescending(x => x.Value).Take(3);
            var first = winners.Take(1);
            var p = winners.Take(2);
            var second = p.TakeLast(1);
            var third = winners.TakeLast(1);
            foreach (var racer in first)
            {
                Console.WriteLine($"1st place: {racer.Key}");
            }
            foreach (var racer in second)
            {
                Console.WriteLine($"2nd place: {racer.Key}");
            }
            foreach (var racer in third)
            {
                Console.WriteLine($"3rd place: {racer.Key}");
            }
        }
    }
}
