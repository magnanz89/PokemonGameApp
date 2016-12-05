using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonAppCore.Models;

namespace PokemonAppCore.DTO
{
    public class PokemonDto : IPokemonDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<PokemonType> Type { get; set; }
        public virtual ICollection<PokemonMove> Moves { get; set; }

        public ICollection<string> Evolutions { get; set; }

        public int? LevelEvolve { get; set; }

        public byte[] PokemonImage { get; set; }

    }
}
