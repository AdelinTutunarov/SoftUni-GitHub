using System;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), sum = 0, days = 0;
            while (n >= 100)
            {
                sum += n;
                days++;
                n -= 10;
                sum -= 26;
            }
            if (sum > 26) sum -= 26;
            else sum = 0;
            Console.WriteLine(days);
            Console.WriteLine(sum);
        }
    }
}
