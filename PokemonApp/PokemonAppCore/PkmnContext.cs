using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonAppCore.Initializers;
using PokemonAppCore.Models;

namespace PokemonAppCore
{
    public class PkmnContext : DbContext, IPkmnContext
    {
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PokemonMove> PokemonMoves { get; set; }
        public DbSet<PokemonType> PokemonTypes { get; set; }

        public DbSet<Versions> Versions { get; set; }

        public DbSet<Feedback> FeedbackInformation { get; set; }

    }
}
