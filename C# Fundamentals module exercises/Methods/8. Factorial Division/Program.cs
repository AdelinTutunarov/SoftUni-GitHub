using System;

namespace _8._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double f1 = Factorial(a);
            double f2 = Factorial(b);
            Console.WriteLine($"{f1/f2:f2}");
        }

        static double Factorial(int a)
        {
            double n = 1;
            while (a > 1)
            {
                n *= a;
                a--;
            }
            return n;
        }
    }
}
