using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonAppCore.DTO;
using PokemonAppCore.Models;

namespace PokemonAppCore.Repositories
{
    public class PokemonRepository
    {
        //implment DI to pass it in contrsuctor

        private readonly IPkmnContext _context;
        
        //should decouple this using DI, but atm just get the context this way
        public PokemonRepository()
        {
            _context = new PkmnContext(); 
        }

        public PokemonDto GetPokemonById(int id)
        {
            return ToPokemonDto(_context.Pokemons.FirstOrDefault(s => s.Id == id));
        }

        //public List<PkmnDTO> GetPokemonByType(string type)
        //{
        //    var pokemonList = _context.Pokemons.Where(s => s.Type.Select(c => c.Name == type);
        //    return ToPokemonDTOList(pokemonList);

        //}

        public PokemonDto ToPokemonDto(Pokemon pokemon)
        {
            return new PokemonDto
            {
                Moves = pokemon.Moves,
                Name = pokemon.Name,
                Type = pokemon.Type,
                Evolutions = pokemon.Evolutions,
                LevelEvolve = pokemon.LevelEvolve,
                PokemonImage = pokemon.PokemonImage,
                Weight = pokemon.Weight,
                Height = pokemon.Height,
                WhereItsFound = pokemon.WhereItsFound,
                PokedexEntry = pokemon.PokedexEntry,
                PokemonId = pokemon.Pokemonid


             };
        }

        public List<PokemonDto> GetAllPokemon()
        {
            var allPokemon = _context.Pokemons.ToList();
            return ToPokemonDTOList(allPokemon);

        }

        public List<PokemonDto> ToPokemonDTOList(IEnumerable<Pokemon> listOfPokemon)
        {
            List<PokemonDto> pkmnDtos = new List<PokemonDto>();

            foreach (var pokemon in listOfPokemon)
            {
                pkmnDtos.Add(new PokemonDto
                {
                    Moves = pokemon.Moves,
                    Name = pokemon.Name,
                    Type = pokemon.Type,
                    Evolutions = pokemon.Evolutions,
                    LevelEvolve = pokemon.LevelEvolve,
                    PokemonImage = pokemon.PokemonImage
                });
            }
            return pkmnDtos;
        }

        public PokemonDto GetPokemonByName(string name)
        {
            return ToPokemonDto(_context.Pokemons.FirstOrDefault(s => s.Name == name));
        }

        public Versions GetVersionOfData()
        {
            return _context.Versions.FirstOrDefault(s => s.Id == 1);
        }

        //postback to db
        //TODO: post back for feedback
        

    }
}
