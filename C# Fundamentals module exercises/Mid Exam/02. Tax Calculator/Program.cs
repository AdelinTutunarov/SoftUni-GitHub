using System;
using System.Linq;

namespace _02._Tax_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vehicles = Console.ReadLine().Split(">>").ToArray();
            int totalTax = 0;
            for (int i = 0; i < vehicles.Length; i++)
            {
                string[] tokens = vehicles[i].Split();
                int tax;
                if (tokens[0] == "family")
                {
                    tax = 50;
                    tax -= int.Parse(tokens[1]) * 5;
                    tax += (int.Parse(tokens[2]) / 3000) * 12;
                    totalTax += tax;
                    Console.WriteLine($"A {tokens[0]} car will pay {tax:f2} euros in taxes.");
                }
                else if (tokens[0] == "heavyDuty")
                {
                    tax = 80;
                    tax -= int.Parse(tokens[1]) * 8;
                    tax += (int.Parse(tokens[2]) / 9000) * 14;
                    totalTax += tax;
                    Console.WriteLine($"A {tokens[0]} car will pay {tax:f2} euros in taxes.");
                }
                else if (tokens[0] == "sports")
                {
                    tax = 100;
                    tax -= int.Parse(tokens[1]) * 9;
                    tax += (int.Parse(tokens[2]) / 2000) * 18;
                    totalTax += tax;
                    Console.WriteLine($"A {tokens[0]} car will pay {tax:f2} euros in taxes.");
                }
                else Console.WriteLine("Invalid car type.");
            }
            Console.WriteLine($"The National Revenue Agency will collect {totalTax:f2} euros in taxes.");
        }
    }
}
