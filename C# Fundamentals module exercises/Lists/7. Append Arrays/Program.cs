using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> symbols = Console.ReadLine().Split("|").Reverse().ToList();
            List<int> numbers = new List<int>();
            foreach(var i in symbols)
            {
                numbers.AddRange(i.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
