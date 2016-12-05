using System.Collections.Generic;

namespace PokemonMobileClient.Model
{
    public class PokemonType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<string> Weaknesses { get; set; }
    }
}