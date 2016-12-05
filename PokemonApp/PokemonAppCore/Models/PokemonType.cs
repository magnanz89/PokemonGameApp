using System.Collections.Generic;

namespace PokemonAppCore.Models
{
    public class PokemonType
    {
        public int Id { get; set; }
        //public virtual Pokemon PokemonId { get; set; }
        public string Name { get; set; }
        public ICollection<string> Weaknesses { get; set; }
    }
}