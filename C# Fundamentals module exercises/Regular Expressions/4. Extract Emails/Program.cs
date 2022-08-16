using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, @"(^|\s)[A-Za-z0-9][\w*\-\.]*[A-Za-z0-9]@[A-Za-z]+([.-][A-Za-z]+)\b");
            matches.ToList().ForEach(Console.WriteLine);
        }
    }
}
