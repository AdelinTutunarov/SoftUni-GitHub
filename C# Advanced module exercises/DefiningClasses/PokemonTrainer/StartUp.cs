using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (string.Join(" ", input) == "Tournament") break;
                if (!trainers.ContainsKey(input[0]))
                {
                    trainers[input[0]] = new Trainer(input[0]);
                }
                Pokemon pokemon = new Pokemon(input[1], input[2], int.Parse(input[3]));
                trainers[input[0]].Pokemons.Add(pokemon);
            }
            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "End") break;
                foreach (var trainer in trainers)
                {
                    trainer.Value.CheckPokemon(cmd);
                }
            }
            List<Trainer> sortedTrainers = trainers.Values.OrderByDescending(t => t.NumberOfBadges).ToList();
            foreach (var trainer in sortedTrainers)
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
