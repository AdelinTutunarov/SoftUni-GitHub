using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nsx = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            for (int i = 0; i < nsx[1]; i++)
            {
                if(stack.Count>0) stack.Pop();
            }
            if (stack.Contains(nsx[2])) Console.WriteLine("true");
            else
            {
                int smallest;
                if (stack.Count > 0) smallest = stack.Peek();
                else smallest = 0;
                while (stack.Count>0)
                {
                    if (stack.Peek() < smallest) smallest = stack.Peek();
                    stack.Pop();
                }
                Console.WriteLine(smallest);
            }
        }
    }
}
