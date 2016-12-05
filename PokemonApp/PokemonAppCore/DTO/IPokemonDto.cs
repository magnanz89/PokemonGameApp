using System.Collections.Generic;
using PokemonAppCore.Models;

namespace PokemonAppCore.DTO
{
    public interface IPokemonDto
    {   
        int Id { get; set; }
        string Name { get; set; }
        ICollection<PokemonType> Type { get; set; }
        ICollection<PokemonMove> Moves { get; set; }

        ICollection<string> Evolutions { get; set; }

        int? LevelEvolve { get; set; }

        byte[] PokemonImage { get; set; }
    }
}