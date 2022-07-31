using System;

namespace _1._Smallest_of_Three_Numbers
{
    class Program
    {
        static int SmallestNumber(int a, int b, int c)
        {
            return Math.Min(a, Math.Min(b, c));
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(SmallestNumber(a, b, c));
        }
    }
}
