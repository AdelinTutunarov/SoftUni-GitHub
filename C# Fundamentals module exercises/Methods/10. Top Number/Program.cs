using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool oddDigcheck = false;
            for (int i = 1; i <= n; i++)
            {
                int p = i, digit, sum = 0;
                while (p > 0)
                {
                    digit = p % 10;
                    if (digit % 2 == 1) oddDigcheck = true;
                    sum += digit;
                    p /= 10;
                }
                if (sum % 8 == 0 && oddDigcheck) Console.WriteLine(i);
                oddDigcheck = false;
            }
        }
    }
}
