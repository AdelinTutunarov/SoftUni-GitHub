using System;
using System.Linq;

namespace GenericBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<double> box = new Box<double>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                box.SomeThings.Add(input);
            }
            double element = double.Parse(Console.ReadLine());
            Console.WriteLine(box.Count(element));
        }
    }
}