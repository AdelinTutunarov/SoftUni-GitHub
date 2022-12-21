using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nsx = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            for (int i = 0; i < nsx[1]; i++)
            {
                if (queue.Count > 0) queue.Dequeue();
            }
            if (queue.Contains(nsx[2])) Console.WriteLine("true");
            else
            {
                int smallest;
                if (queue.Count > 0) smallest = queue.Peek();
                else smallest = 0;
                while (queue.Count > 0)
                {
                    if (queue.Peek() < smallest) smallest = queue.Peek();
                    queue.Dequeue();
                }
                Console.WriteLine(smallest);
            }
        }
    }
}
