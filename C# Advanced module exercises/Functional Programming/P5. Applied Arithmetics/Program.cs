using System;
using System.Collections.Generic;
using System.Linq;

namespace P5._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Action<List<int>> add = (list) =>
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list[i]++;
                }
            };
            Action<List<int>> subtract = (list) =>
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list[i]--;
                }
            };
            Action<List<int>> multiply = (list) =>
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list[i]*=2;
                }
            };
            Action<List<int>> print = (list) => Console.WriteLine(String.Join(" ", list));
            string cmd = Console.ReadLine();
            while (cmd!="end")
            {
                switch (cmd)
                {
                    case "add":
                        add(input);
                        break;
                    case "multiply":
                        multiply(input);
                        break;
                    case "subtract":
                        subtract(input);
                        break;
                    case "print":
                        print(input);
                        break;
                    default:
                        break;
                }
                cmd = Console.ReadLine();
            }
        }
    }
}
