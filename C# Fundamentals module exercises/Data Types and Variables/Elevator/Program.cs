using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            if (n % p != 0) Console.WriteLine(n / p + 1);
            else Console.WriteLine(n / p);
        }
    }
}
