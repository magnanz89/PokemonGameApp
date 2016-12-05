using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PokemonMobileClient.Model;

namespace PokemonMobileClient.DTO
{
    public class PokemonDTO
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