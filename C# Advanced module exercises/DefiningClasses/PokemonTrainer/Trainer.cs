using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name)
        {
            Name = name;
            Pokemons = new List<Pokemon>();
            NumberOfBadges = 0;
        }
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        public void CheckPokemon(string element)
        {
            if(Pokemons.Any(p => p.Element==element)) NumberOfBadges++;
            else
            {
                foreach (var pokemon in Pokemons)
                {
                    pokemon.Health -= 10;
                    if(pokemon.Health <= 0) Pokemons.Remove(pokemon);
                }
            }
        }
    }
}
