using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using PokemonAppCore.DTO;
using PokemonAppCore.Exceptions;
using PokemonAppCore.Repositories;

namespace PokemonApp.Controllers
{
    [RoutePrefix("Pkmn")]
    public class PokemonController : ApiController
    {
        private readonly PokemonRepository _pokeRepo;

        public PokemonController()
        {
            _pokeRepo = new PokemonRepository();
      
        }


        [Route("GetAllPokemon")]
        public List<PokemonDto> GetAllPokemon()
        {
            List<PokemonDto> allPokemon;
            try
            {
                allPokemon = _pokeRepo.GetAllPokemon();
            }
            catch (Exception e)
            {
              throw new FailedToAccessDbException(e);
            }
            return allPokemon;
        }

        [Route("GetPokemonById")]
        public PokemonDto GetPokemonById(int id)
        {
            PokemonDto pokemonWithId;

            try
            {
                pokemonWithId = _pokeRepo.GetPokemonById(id);
            }
            catch (Exception e)
            {
                throw new FailedToAccessDbException(e);
            }
            return pokemonWithId;
        }

        [Route("GetPokemonByName")]
        public PokemonDto GetPokemonByName(string name)
        {
            PokemonDto pokemon;

            try
            {
                pokemon = _pokeRepo.GetPokemonByName(name);
            }
            catch (Exception e)
            {
                throw new FailedToAccessDbException(e);
            }
            return pokemon;
        }

        [Route("GetVersionNumber")]
        public string GetVersionNumber()
        {
            return _pokeRepo.GetVersionOfData().ToString();
        }

    }
}
