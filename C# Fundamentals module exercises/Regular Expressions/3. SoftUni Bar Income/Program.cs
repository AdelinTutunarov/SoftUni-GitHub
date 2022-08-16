using System;
using System.Text.RegularExpressions;

namespace _3._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>[\w]+)>[^|$%.]*\|(?<count>[\d]+)\|[^|$%.]*?(?<price>[\d]+.?[\d+])?\$");
            string input = Console.ReadLine();
            double totalIncome = 0;
            while (input != "end of shift")
            {
                if (regex.IsMatch(input))
                {
                    totalIncome += int.Parse(regex.Match(input).Groups["count"].Value) * double.Parse(regex.Match(input).Groups["price"].Value);
                    Console.WriteLine($"{regex.Match(input).Groups["customer"].Value}: {regex.Match(input).Groups["product"].Value} - {int.Parse(regex.Match(input).Groups["count"].Value) * double.Parse(regex.Match(input).Groups["price"].Value):f2}");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
