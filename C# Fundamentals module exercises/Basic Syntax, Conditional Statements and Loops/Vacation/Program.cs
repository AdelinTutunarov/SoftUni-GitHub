using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double p = 0;
            double sum = 0;
            switch (type)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            p = 8.45;
                            break;
                        case "Saturday":
                            p = 9.80;
                            break;
                        case "Sunday":
                            p = 10.46;
                            break;
                    }
                    if (count >= 30) sum = (p * count) * 0.85;
                    else sum = p * count;
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            p = 10.90;
                            break;
                        case "Saturday":
                            p = 15.60;
                            break;
                        case "Sunday":
                            p = 16;
                            break;
                    }
                    if (count >= 100) sum = p * (count - 10);
                    else sum = p * count;
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            p = 15;
                            break;
                        case "Saturday":
                            p = 20;
                            break;
                        case "Sunday":
                            p = 22.50;
                            break;
                    }
                    if (count >= 10 && count <= 20) sum = (p * count) * 0.95;
                    else sum = p * count;
                    break;
            }
            Console.WriteLine($"Total price: {sum:f2}");
        }
    }
}
