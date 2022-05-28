using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), p, sum = 0;
            for (int i = 0; i < n; i++)
            {
                p = int.Parse(Console.ReadLine());
                if (sum + p <= 255) sum += p;
                else Console.WriteLine("Insufficient capacity!");
            }
            Console.WriteLine(sum);
        }
    }
}
