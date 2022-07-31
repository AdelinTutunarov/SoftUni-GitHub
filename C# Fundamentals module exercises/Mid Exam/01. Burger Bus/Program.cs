using System;

namespace _01._Burger_Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCitys = int.Parse(Console.ReadLine());
            bool rainyDay = false;
            double totalProfit = 0;
            for (int i = 1; i <= numberOfCitys; i++)
            {
                string cityName = Console.ReadLine();
                double income = double.Parse(Console.ReadLine());
                double expenses = double.Parse(Console.ReadLine());
                double profit;
                if (i % 5 == 0)
                {
                    income *= 0.9;
                    rainyDay = true;
                }
                if (i % 3 == 0 && !rainyDay)
                {
                    expenses *= 1.5;
                }
                profit = income - expenses;
                totalProfit += profit;
                Console.WriteLine($"In {cityName} Burger Bus earned {profit:f2} leva.");
                rainyDay = false;
            }
            Console.WriteLine($"Burger Bus total profit: {totalProfit:f2} leva.");
        }
    }
}
