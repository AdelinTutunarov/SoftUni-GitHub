using System;

namespace Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a >= 0 && a <= 2) Console.WriteLine("baby");
            else if (a > 2 && a <= 13) Console.WriteLine("child");
            else if (a > 13 && a <= 19) Console.WriteLine("teenager");
            else if (a > 19 && a <= 65) Console.WriteLine("adult");
            else Console.WriteLine("elder");
        }
    }
}
