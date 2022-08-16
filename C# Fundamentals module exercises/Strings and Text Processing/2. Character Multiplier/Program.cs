using System;

namespace _2._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            
            Multiplication(input[0], input[1]);
        }
        public static void Multiplication(string str1, string str2)
        {
            int biggerLength = Math.Max(str1.Length, str2.Length), sum = 0;
            for (int i = 0; i < biggerLength; i++)
            {
                if (i >= str1.Length) sum += str2[i];
                else if (i >= str2.Length) sum += str1[i];
                else sum += str1[i] * str2[1];
            }
            Console.WriteLine(sum);
        }
    }
}

