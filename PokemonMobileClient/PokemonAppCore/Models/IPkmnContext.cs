using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAppCore.Models
{
    public interface IPkmnContext
    {
        DbSet<Pokemon> Pokemons { get; set; }
        DbSet<PokemonMove> PokemonMoves { get; set; }
        DbSet<PokemonType> PokemonTypes { get; set; }
    }
}
