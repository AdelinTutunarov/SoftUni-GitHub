using System;

namespace Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char p = 'a';
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        Console.Write((char)(p + i));
                        Console.Write((char)(p + j));
                        Console.Write((char)(p + k));
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
