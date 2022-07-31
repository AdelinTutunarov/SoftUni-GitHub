using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int sum = 0;
            while (myList.Any())
            {
                int index = int.Parse(Console.ReadLine());
                if (index < 0)
                {
                    int number = myList[0];
                    myList[0] = myList[myList.Count - 1];
                    sum += number;
                    Operation(myList, number);
                }
                else if (index > myList.Count - 1)
                {
                    int number = myList[myList.Count - 1];
                    myList[myList.Count - 1] = myList[0];
                    sum += number;
                    Operation(myList, number);
                }
                else
                {
                    int number = myList[index];
                    myList.RemoveAt(index);
                    Operation(myList, number);
                    sum += number;
                }
            }
            Console.WriteLine(sum);
        }

        private static void Operation(List<int> myList, int number)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i] <= number) myList[i] += number;
                else myList[i] -= number;
            }
        }
    }
}
