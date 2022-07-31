﻿using System;

namespace _1._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phares = { "Excellent product.", "Such a great product.",
                "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] names = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random random = new Random();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{phares[random.Next(0, phares.Length)]} {events[random.Next(0, events.Length)]} {names[random.Next(0, names.Length)]} - {cities[random.Next(0, cities.Length)]}.");
            }
        }
    }
}
