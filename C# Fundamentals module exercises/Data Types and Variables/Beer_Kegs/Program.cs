using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string model = Console.ReadLine(), DaBigOne = model;
            double radius = float.Parse(Console.ReadLine());
            double height = int.Parse(Console.ReadLine());
            double capacity = Math.PI * radius * radius * height;
            for (int i = 1; i < n; i++)
            {
                model = Console.ReadLine();
                radius = float.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());
                if (capacity < Math.PI * radius * radius * height)
                {
                    capacity = Math.PI * radius * radius * height;
                    DaBigOne = model;
                }
            }
            Console.WriteLine(DaBigOne);
        }
    }
}
