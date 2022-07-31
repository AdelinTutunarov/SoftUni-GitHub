using System;
using System.Linq;

namespace _2._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            CountVowels(input);
        }

        static void CountVowels(string text)
        {
            Console.WriteLine(text.Count(vowels => "aeuoi".Contains(vowels)));
        }
    }
}
