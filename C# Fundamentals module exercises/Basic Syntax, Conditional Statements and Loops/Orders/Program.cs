using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double price, sum = 0, p, days, capsules;
            for (int i = 0; i < n; i++)
            {
                price = double.Parse(Console.ReadLine());
                days = double.Parse(Console.ReadLine());
                capsules = double.Parse(Console.ReadLine());
                p = days * capsules * price;
                Console.WriteLine($"The price for the coffee is: ${p:f2}");
                sum += p;
            }
            Console.WriteLine($"Total: ${sum:f2}");
        }
    }
}
