﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfQueries = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < numberOfQueries; i++)
            {
                int[] query = Console.ReadLine().Split().Select(int.Parse).ToArray();
                switch (query[0])
                {
                    case 1:
                        stack.Push(query[1]);
                        break;
                    case 2:
                        if (stack.Count > 0) stack.Pop();
                        break;
                    case 3:
                        if (stack.Count > 0) Console.WriteLine(stack.Max());
                        break;
                    case 4:
                        if (stack.Count > 0) Console.WriteLine(stack.Min());
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
