using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonAppCore.DTO;
using PokemonAppCore.Repositories;

namespace PokemonAppCore.Service
{
    public class PokemonService
    {
        private PokemonRepository _pokeRepo;
        public PokemonService()
        {
            _pokeRepo = new PokemonRepository();
        }


        public List<PokemonDto> GetAllPokemon()
        {
            return _pokeRepo.GetAllPokemon();
        }

        public PokemonDto GetPokemonById(int id)
        {
            return _pokeRepo.GetPokemonById(id);
        }

        public PokemonDto GetPokemonByName(string name)
        {
            return GetPokemonByName(name);
        }


    }
}
