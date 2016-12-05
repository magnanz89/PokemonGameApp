using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using PokemonAppCore.Repositories;

namespace PokemonConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokeRepo = new PokemonRepository();

            Console.WriteLine("Get pokemon by Id");
            var pokemonById = pokeRepo.GetPokemonById(1);
            Console.WriteLine(pokemonById.Name);
            Console.ReadKey();

            Console.WriteLine("Get pokemon by Id");
            var allPokemon = pokeRepo.GetAllPokemon();
            Console.WriteLine("Count: "+allPokemon.Count);
            foreach (var pokemon in allPokemon)
            {
                Console.WriteLine("pokemon name: " + pokemon.Name);
                Console.WriteLine("Level evolves: "+ pokemon.LevelEvolve);
            }


            Console.ReadKey();

        }
    }
}
