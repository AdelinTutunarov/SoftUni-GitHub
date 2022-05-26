using System;

namespace Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()), p = number, digit, sum = 0, h;
            while (p > 0)
            {
                digit = p % 10;
                h = digit;
                for (int i = digit - 1; i > 1; i--)
                {
                    h *= i;
                }
                sum += h;
                p /= 10;
            }
            if (sum == number) Console.WriteLine("yes");
            else Console.WriteLine("no");
        }
    }
}
