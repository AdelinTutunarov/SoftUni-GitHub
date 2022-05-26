using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double students = int.Parse(Console.ReadLine());
            double lightsaberprice = double.Parse(Console.ReadLine());
            double robeprice = double.Parse(Console.ReadLine());
            double beltprice = double.Parse(Console.ReadLine());
            double sum = lightsaberprice * (students + Math.Ceiling(students / 10));
            sum += robeprice * students;
            sum += beltprice * (students - Math.Floor(students / 6));
            if(sum <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {sum - money:f2}lv more.");
            }
        }
    }
}
