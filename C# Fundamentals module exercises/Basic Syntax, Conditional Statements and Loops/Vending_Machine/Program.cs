using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine(), product = "";
            double sum = 0, p = 0;
            while (command != "Start")
            {
                if (command == "0.1" || command == "0.2" || command == "0.5" || command == "1" || command == "2")
                {
                    sum += double.Parse(command);
                }
                else Console.WriteLine($"Cannot accept {command}");
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while (command != "End")
            {
                switch (command)
                {
                    case "Nuts":
                        sum -= 2;
                        product = "nuts";
                        p = 2;
                        break;
                    case "Water":
                        sum -= 0.7;
                        product = "water";
                        p = 0.7;
                        break;
                    case "Crisps":
                        sum -= 1.5;
                        product = "crisps";
                        p = 1.5;
                        break;
                    case "Soda":
                        sum -= 0.8;
                        product = "soda";
                        p = 0.8;
                        break;
                    case "Coke":
                        sum -= 1;
                        product = "coke";
                        p = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                if (sum < 0)
                {
                    Console.WriteLine("Sorry, not enough money");
                    sum += p;
                }
                else if (product != "")
                {
                    Console.WriteLine($"Purchased {product}");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
