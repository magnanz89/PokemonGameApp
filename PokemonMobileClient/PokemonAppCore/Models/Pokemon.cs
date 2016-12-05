﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAppCore.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<PokemonType> Type { get; set; }
        public virtual ICollection<PokemonMove> Moves { get; set; } 
        
        public ICollection<string> Evolutions { get; set; } 

        public int? LevelEvolve { get; set; }
        public string PokedexEntry { get; set; }

        public byte[] PokemonImage { get; set; }
        public float Weight { get; set; }
        public string Height { get; set; }
        public string WhereItsFound { get; set; }

    }
}