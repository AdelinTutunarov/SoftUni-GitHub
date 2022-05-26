using System;

namespace Ages2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string result = a >= 0 && a <= 2 ? "baby" :
                a <= 13 ? "child" :
                a <= 19 ? "teenager" :
                a <= 65 ? "adult" : "elder";
            Console.WriteLine(result);
        }
    }
}
