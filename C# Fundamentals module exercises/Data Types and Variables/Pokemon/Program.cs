using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());
            double m = int.Parse(Console.ReadLine());
            double y = int.Parse(Console.ReadLine());
            int count = 0;
            double p = n;
            while (p >= m)
            {
                p -= m;
                count++;
                if (n % p == 0 && n / 2 == p && y > 0)
                {
                    p = Math.Floor(p / y);
                }
            }
            Console.WriteLine(p);
            Console.WriteLine(count);
        }
    }
}
