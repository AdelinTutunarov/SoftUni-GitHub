using System;
using System.Collections.Generic;

namespace _1._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charecters = new Dictionary<char, int>();
            char[] input = Console.ReadLine().ToCharArray();
            foreach (var i in input)
            {
                if(i!=' ')
                {
                    if (!charecters.ContainsKey(i)) charecters[i] = 1;
                    else charecters[i] += 1;
                }
            }
            foreach (var i in charecters) Console.WriteLine($"{i.Key} -> {i.Value}");
        }
    }
}
