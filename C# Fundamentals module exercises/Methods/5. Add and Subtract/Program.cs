using System;

namespace _5._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());
            Console.WriteLine(Substract(Add(firstInt,secondInt),thirdInt));
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Substract(int a, int b)
        {
            return a - b;
        }
    }
}
