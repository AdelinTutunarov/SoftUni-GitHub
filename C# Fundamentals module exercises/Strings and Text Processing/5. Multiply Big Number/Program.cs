using System;
using System.Text;

namespace _5._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int digit = int.Parse(Console.ReadLine());
            if(digit != 0)
            {
                StringBuilder result = new StringBuilder();
                int p = 0;
                for (int i = number.Length - 1; i >= 0; i--)
                {
                    int product = digit * int.Parse(number[i].ToString()) + p;
                    result.Append(product % 10);
                    p = product / 10;
                }
                if (p != 0) result.Append(p);
                for (int i = result.Length - 1; i >= 0; i--)
                {
                    Console.Write(result[i]);
                }
            }
            else Console.WriteLine(0);
        }
    }
}
