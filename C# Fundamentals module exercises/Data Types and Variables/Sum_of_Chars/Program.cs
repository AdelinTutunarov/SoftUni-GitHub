using System;

namespace Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), sum = 0;
            char[] p = new char[n];
            for (int i = 0; i < n; i++)
            {
                p[i] = char.Parse(Console.ReadLine());
                sum += p[i];
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
