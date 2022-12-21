using System;
using System.Linq;

namespace _7._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()),p = 0;
            bool check = false;
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if(input[0] - input[1] >= 0 && !check)
                {
                    p = i;
                    check = true;
                }
            }
            Console.WriteLine(p);
        }
    }
}
