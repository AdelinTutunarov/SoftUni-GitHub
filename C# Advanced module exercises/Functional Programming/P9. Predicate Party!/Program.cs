using System;
using System.Collections.Generic;
using System.Linq;

namespace P9._Predicate_Party_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (string.Join(" ",cmd)== "Party!") break;
                switch (cmd[0])
                {
                    case "Remove":
                        names.RemoveAll(GetPredicate(cmd[1], cmd[2]));
                        break;
                    case "Double":
                        if (names.FindIndex(GetPredicate(cmd[1], cmd[2])) >= 0) 
                            names.InsertRange(names.FindIndex(GetPredicate(cmd[1], cmd[2])),
                                names.FindAll(GetPredicate(cmd[1], cmd[2])));
                        break;
                    default:
                        break;
                }
            }
            if (names.Any()) Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            else Console.WriteLine("Nobody is going to the party!");
        }
        static Predicate<string> GetPredicate(string filter, string x)
        {
            switch (filter)
            {
                case "StartsWith":
                    return p => p.StartsWith(x);
                case "EndsWith":
                    return p => p.EndsWith(x);
                case "Length":
                    return p => p.Length == int.Parse(x);
                default:
                    return default(Predicate<string>);
            }
        }
    }
}
