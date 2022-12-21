using System;

namespace Threeuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] randomPerson = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Threeuple<string, string, string> randomThreeuple =
                new Threeuple<string, string, string>($"{randomPerson[0]} {randomPerson[1]}", randomPerson[2], randomPerson[3]);
            string[] drunkard = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            bool isDrunk = drunkard[2] == "drunk"? true : false;
            Threeuple<string, int, bool> drunkardThreeuple =
                new Threeuple<string, int, bool>(drunkard[0], int.Parse(drunkard[1]), isDrunk);
            string[] bankCostumer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Threeuple<string, double, string> bankCostumerThreeuple =
                new Threeuple<string, double, string>(bankCostumer[0], double.Parse(bankCostumer[1]), bankCostumer[2]);
            Console.WriteLine(randomThreeuple);
            Console.WriteLine(drunkardThreeuple);
            Console.WriteLine(bankCostumerThreeuple);
        }
    }
}
