using System;
using System.Collections.Generic;

namespace _7._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, List<string>>();
            string[] cmd = Console.ReadLine().Split(" -> ");
            while (cmd[0] != "End")
            {
                if (!companies.ContainsKey(cmd[0])) companies.Add(cmd[0], new List<string>());
                if (!companies[cmd[0]].Contains(cmd[1])) companies[cmd[0]].Add(cmd[1]);

                cmd = Console.ReadLine().Split(" -> ");
            }
            foreach (var company in companies)
            {
                Console.WriteLine(company.Key);
                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
