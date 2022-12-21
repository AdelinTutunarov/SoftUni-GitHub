using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int rackCapacity = int.Parse(Console.ReadLine());
            int sum = 0, numberOfRacks = 1;
            while (clothes.Count > 0)
            {
                if (sum + clothes.Peek() > rackCapacity)
                {
                    sum = 0;
                    numberOfRacks++;
                }
                else
                {
                    sum += clothes.Pop();
                }
            }
            Console.WriteLine(numberOfRacks);
        }
    }
}
