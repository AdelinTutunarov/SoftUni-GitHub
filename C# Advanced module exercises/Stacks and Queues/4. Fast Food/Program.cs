using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Console.WriteLine(orders.Max());
            while (orders.Count > 0)
            {
                if (foodQuantity - orders.Peek() >= 0)
                {
                    foodQuantity -= orders.Peek();
                    orders.Dequeue();
                }
                else break;
            }
            if (orders.Count > 0) Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            else Console.WriteLine("Orders complete");
        }
    }
}
