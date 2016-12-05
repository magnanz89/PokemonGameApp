using System.Collections.Generic;
using PokemonAppCore.Initializers;
using PokemonAppCore.Models;

namespace PokemonAppCore.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PokemonAppCore.PkmnContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PokemonAppCore.PkmnContext context)
        {
            var pokemon1 = new Pokemon
            {
                Name = "Bulbasaur",
                Id = 1,
                PokedexEntry = "A strange seed was planted on its back at birth. The plant sprouts and grows with this Pokémon.",
                Weight = 14.0f,
                Height = "2' 14\"",
                WhereItsFound = "Pallet Town",
                Moves = new List<PokemonMove>
                {
                    new PokemonMove
                    {

                        Name = "Tackle",
                        Damage = 5,
                        LevelGained = 5,
                        GenerationMoveFirstAppearedIn = 1,
                        Type = "Normal"

                    },
                    new PokemonMove
                    {
                        Name = "Growl",
                        Damage = 0,
                        GenerationMoveFirstAppearedIn = 1,
                        LevelGained = 5,
                        Type = "Normal"
                    },
                    new PokemonMove
                    {
                        Name = "Leech Seed",
                        Damage = 5,
                        GenerationMoveFirstAppearedIn = 1,
                        LevelGained = 7,
                        Type = "Grass"
                    },
                    new PokemonMove
                    {
                        Name = "Vine Whip",
                        Damage = 5,
                        GenerationMoveFirstAppearedIn = 1,
                        LevelGained = 13,
                        Type = "Grass"
                    },
                    new PokemonMove
                    {
                        Name = "Poison Powder",
                        Damage = 5,
                        GenerationMoveFirstAppearedIn = 1,
                        LevelGained = 20,
                        Type = "Poison"
                    },
                    new PokemonMove
                    {
                        Name = "Razer Leaf",
                        Damage = 5,
                        GenerationMoveFirstAppearedIn = 1,
                        LevelGained = 27,
                        Type = "Grass"
                    },
                    new PokemonMove
                    {
                        Name = "Growth",
                        Damage = 5,
                        GenerationMoveFirstAppearedIn = 1,
                        LevelGained = 34,
                        Type = "Normal"
                    },
                    new PokemonMove
                    {
                        Name = "Sleep Powder",
                        Damage = 5,
                        GenerationMoveFirstAppearedIn = 1,
                        LevelGained = 41,
                        Type = "Grass"
                    },
                    new PokemonMove
                    {
                        Name = "Solar Beam",
                        Damage = 5,
                        GenerationMoveFirstAppearedIn = 1,
                        LevelGained = 48,
                        Type = "Grass"
                    }
                },
                Type = new List<PokemonType>
                {
                    new PokemonType
                    {
                        Name = "Grass",
                        Weaknesses = new List<string>
                        {
                            "Water"
                        }
                    }
                },
                Evolutions = new List<string>
                {
                    "Ivysaur",
                    "Venusaur"
                },
                LevelEvolve = 16
            };
            context.Pokemons.AddOrUpdate(s => s.Id, pokemon1);

            var pokemon2 = new Pokemon
            {
                Id = 2,
                Name = "Ivysaur",
                Height = "3' 3\"",
                PokedexEntry = "When the bulb on its back grows large,it appears to lose the speed to stand on its hind legs.",
                Weight = 29.0f,
                WhereItsFound = "Can only be obtained through evolution.",

                Moves = new List<PokemonMove>
                {
                    new PokemonMove
                    {
                        Name = "Poison Powder",
                        Damage = 10,
                        GenerationMoveFirstAppearedIn = 1,
                        Type = "Poison",
                        LevelGained = 22
                    },
                    new PokemonMove
                    {
                        Name = "Razor Leaf",
                        Damage = 5,
                        GenerationMoveFirstAppearedIn = 1,
                        LevelGained = 30,
                        Type = "Grass"
                    },
                    new PokemonMove
                    {
                        Name = "Growth",
                        Damage = 5,
                        GenerationMoveFirstAppearedIn = 1,
                        LevelGained = 38,
                        Type = "Normal"
                    },
                    new PokemonMove
                    {
                        Name = "Sleep Powder",
                        Damage = 5,
                        GenerationMoveFirstAppearedIn = 1,
                        LevelGained = 46,
                        Type = "Grass"
                    },
                    new PokemonMove
                    {
                        Name = "Solar Beam",
                        Damage = 5,
                        GenerationMoveFirstAppearedIn = 1,
                        LevelGained = 54,
                        Type = "Grass"
                    }
                },
                Type = new List<PokemonType>
                {
                    new PokemonType
                    {
                        Name = "Grass",
                        Weaknesses = new List<string>
                        {
                            "Water"
                        }
                    }
                },
                Evolutions = new List<string>
                {
                    "Bulbasaur",
                    "Venusaur"
                },
                LevelEvolve = 32
            };
            context.Pokemons.AddOrUpdate(s => s.Id, pokemon2);

            var pokemon3 = new Pokemon
            {
                WhereItsFound = "Can only be obtained through evolution",
                Height = "6' 7\"",
                Weight = 221.0f,
                PokedexEntry = "The plant blooms when it is absorbing solar energy. It stays on the move to seek sunlight.",
                
                Id = 3,
                Name = "Venusaur",
                Moves = new List<PokemonMove>
                {
                    new PokemonMove
                    {
                        Name = "Growth",
                        Damage = 50,
                        GenerationMoveFirstAppearedIn = 1,
                        Type = "Normal",
                        LevelGained = 43
                    },
                    new PokemonMove
                    {
                        Name = "Sleep Powder",
                        Damage = 0,
                        GenerationMoveFirstAppearedIn = 1,
                        Type = "Grass",
                        LevelGained = 55
                    },
                    new PokemonMove
                    {
                        Name = "Solar Beam",
                        Damage = 0,
                        GenerationMoveFirstAppearedIn = 1,
                        Type = "Grass",
                        LevelGained = 65
                    }
                },
                Type = new List<PokemonType>
                {
                    new PokemonType
                    {
                        Name = "Grass",
                        Weaknesses = new List<string>
                        {
                            "Water"
                        }
                    }
                },
                Evolutions = new List<string>
                {
                    "Bulbasaur",
                    "Ivysaur"
                },
                LevelEvolve = null
            };

            context.Pokemons.AddOrUpdate(s => s.Id, pokemon3);

            var pokemon4 = new Pokemon
            {
                Id = 4,
                Name = "Charmander",
                WhereItsFound = "Pallet Town",
                Height = "2' 0\"",
                Weight = 19.0f,
                PokedexEntry = "Obviously prefers hot places.When it rains,steam is said to spout from the tip of its tail.",
                

                Moves = new List<PokemonMove>
                {
                    new PokemonMove
                    {
                        Name = "Scratch",
                        Damage = 10,
                        GenerationMoveFirstAppearedIn = 1,
                        Type = "Normal",
                        LevelGained = 5
                    },
                    new PokemonMove
                    {
                        Name = "Growl",
                        Damage = 0,
                        GenerationMoveFirstAppearedIn = 1,
                        Type = "Normal",
                        LevelGained = 5
                    },
                    new PokemonMove
                    {
                        Name = "Ember",
                        Damage = 0,
                        GenerationMoveFirstAppearedIn = 1,
                        Type = "Fire",
                        LevelGained = 9
                    },
                    new PokemonMove
                    {
                        Name = "Leer",
                        Damage = 0,
                        GenerationMoveFirstAppearedIn = 1,
                        Type = "Normal",
                        LevelGained = 15
                    },
                    new PokemonMove
                    {
                        Name = "Rage",
                        Damage = 0,
                        GenerationMoveFirstAppearedIn = 1,
                        Type = "Normal",
                        LevelGained = 22
                    },
                    new PokemonMove
                    {
                        Name = "Slash",
                        Damage = 0,
                        GenerationMoveFirstAppearedIn = 1,
                        Type = "Normal",
                        LevelGained = 30
                    },
                    new PokemonMove
                    {
                        Name = "Flamethrower",
                        Damage = 0,
                        GenerationMoveFirstAppearedIn = 1,
                        Type = "Fire",
                        LevelGained = 38
                    },
                    new PokemonMove
                    {
                        Name = "Fire Spin",
                        Damage = 0,
                        GenerationMoveFirstAppearedIn = 1,
                        Type = "Fire",
                        LevelGained = 46
                    }

                },
                Type = new List<PokemonType>
                {
                    new PokemonType
                    {
                        Name = "Fire",
                        Weaknesses = new List<string>
                        {
                            "Water"
                        }
                    }
                },
                Evolutions = new List<string>
                {
                    "Charmeleon",
                    "Charizard"
                },
                LevelEvolve = 16
            };
            context.Pokemons.AddOrUpdate(s => s.Id, pokemon4);

            var pokemon5 = new Pokemon
            {
                Id = 5,
                Name = "Charmeleon",
                WhereItsFound = "Can only be obtained through evolution",
                Height = "3' 7\"",
                Weight = 42.0f,
                PokedexEntry = "When it swings its burning tail, it elevates the temperature to unbearably high levels.",
                
                Moves = new List<PokemonMove>
                {
                    new PokemonMove
                    {
                        Name = "Rage",
                        Damage = 10,
                        GenerationMoveFirstAppearedIn = 1,
                        Type = "Normal",
                        LevelGained = 24
                    },
                    new PokemonMove
                    {
                        Name = "Slash",
                        Damage = 0,
                        GenerationMoveFirstAppearedIn = 1,
                        Type = "Normal",
                        LevelGained = 33
                    },
                    new PokemonMove
                    {
                        Name = "Flamethrower",
                        Damage = 0,
                        GenerationMoveFirstAppearedIn = 1,
                        Type = "Fire",
                        LevelGained = 42
                    },
                    new PokemonMove
                    {
                        Name = "Fire Spin",
                        Damage = 0,
                        GenerationMoveFirstAppearedIn = 1,
                        Type = "Fire",
                        LevelGained = 56
                    }
                },
                Type = new List<PokemonType>
                {
                    new PokemonType
                    {
                        Name = "Fire",
                        Weaknesses = new List<string>
                        {
                            "Water"
                        }
                    }
                },
                Evolutions = new List<string>
                {
                    "Charmander",
                    "Charizard"
                },
                LevelEvolve = 36
            };
            context.Pokemons.AddOrUpdate(s => s.Id, pokemon5);

            var charizard = new Pokemon
            {
                Name = "Charizard",
                Id = 6,
                Height = "5' 7\"",
                WhereItsFound = "Can only be obtained through evolution.",
                PokedexEntry = "Spits fire that is hot enough to melt boulders. Known to cause forest fires unintentionally.",
                Weight = 200.0f,
                LevelEvolve = null,
                Evolutions = new List<string>
                {
                    "Charmander",
                    "Charmeleon"
                },
                Type = new List<PokemonType>
                {
                    new PokemonType
                    {
                        Name = "Fire",
                        Weaknesses = new List<string>
                        {
                            "Water"
                        }
                    }
                },
                Moves = new List<PokemonMove>
                {
                    new PokemonMove
                    {
                        Name = "Slash",
                        Type = "Normal",
                        LevelGained = 36,
                        GenerationMoveFirstAppearedIn = 1
                    },
                    new PokemonMove
                    {
                        Name = "Flamethrower",
                        Type = "Fire",
                        LevelGained = 46,
                        GenerationMoveFirstAppearedIn = 1
                    },
                    new PokemonMove
                    {
                        Name = "Fire Spin",
                        Type = "Fire",
                        LevelGained = 55,
                        GenerationMoveFirstAppearedIn = 1
                    }
                }
            };
            context.Pokemons.AddOrUpdate(s => s.Id, charizard);

            var squirtle = new Pokemon
            {
                Name = "Squirtle",
                Id = 7,
                Height = "1' 8\"",
                WhereItsFound = "Pallet Town",
                PokedexEntry = "After birth, its back swells and hardens into a shell. Powerfully sprays foam from its mouth.",
                Weight = 20.0f,
                LevelEvolve = 16,
                Evolutions = new List<string>
                {
                    "Wartortle",
                    "Blastoise"
                },
                Type = new List<PokemonType>
                {
                    new PokemonType
                    {
                        Name = "Water",
                        Weaknesses = new List<string>
                        {
                            "Grass"
                        }
                    }
                },
                Moves = new List<PokemonMove>
                {
                    new PokemonMove
                    {
                        Name = "Tackle",
                        Type = "Normal",
                        LevelGained = 5,
                        GenerationMoveFirstAppearedIn = 1
                    },
                    new PokemonMove
                    {
                        Name = "Tail Whip",
                        Type = "Normal",
                        LevelGained = 5,
                        GenerationMoveFirstAppearedIn = 1
                    },
                    new PokemonMove
                    {
                        Name = "Bubble",
                        Type = "Water",
                        LevelGained = 8,
                        GenerationMoveFirstAppearedIn = 1
                    },
                    new PokemonMove
                    {
                        Name = "Water Gun",
                        Type = "Water",
                        LevelGained = 15,
                        GenerationMoveFirstAppearedIn = 1
                    },
                    new PokemonMove
                    {
                        Name = "Bite",
                        Type = "Normal",
                        LevelGained = 22,
                        GenerationMoveFirstAppearedIn = 1
                    },
                    new PokemonMove
                    {
                        Name = "Withdraw",
                        Type = "Water",
                        LevelGained = 28,
                        GenerationMoveFirstAppearedIn = 1
                    },
                    new PokemonMove
                    {
                        Name = "Skull Bash",
                        Type = "Normal",
                        LevelGained = 35,
                        GenerationMoveFirstAppearedIn = 1
                    },
                    new PokemonMove
                    {
                        Name = "Hydro Pump",
                        Type = "Water",
                        LevelGained = 42,
                        GenerationMoveFirstAppearedIn = 1
                    }
                }
            };
            context.Pokemons.AddOrUpdate(s => s.Id, squirtle);

            var wartortle = new Pokemon
            {
                Name = "Wartortle",
                Id = 8,
                Height = "3' 3\"",
                WhereItsFound = "Can only be obtained through evolution",
                PokedexEntry = "Often hides in water to stalk unwary prey. For swimming fast, it moves its ears to maintain balance",
                Weight = 50.0f,
                LevelEvolve = 36,
                Evolutions = new List<string>
                {
                    "Squirtle",
                    "Blastoise"
                },
                Type = new List<PokemonType>
                {
                    new PokemonType
                    {
                        Name = "Water",
                        Weaknesses = new List<string>
                        {
                            "Grass"
                        }
                    }
                },
                Moves = new List<PokemonMove>
                {
                    
                    new PokemonMove
                    {
                        Name = "Bite",
                        Type = "Normal",
                        LevelGained = 24,
                        GenerationMoveFirstAppearedIn = 1
                    },
                    new PokemonMove
                    {
                        Name = "Withdraw",
                        Type = "Water",
                        LevelGained = 31,
                        GenerationMoveFirstAppearedIn = 1
                    },
                    new PokemonMove
                    {
                        Name = "Skull Bash",
                        Type = "Normal",
                        LevelGained = 39,
                        GenerationMoveFirstAppearedIn = 1
                    },
                    new PokemonMove
                    {
                        Name = "Hydro Pump",
                        Type = "Water",
                        LevelGained = 47,
                        GenerationMoveFirstAppearedIn = 1
                    }
                }
            };
            context.Pokemons.AddOrUpdate(s => s.Id, wartortle);

            var blastoise = new Pokemon
            {
                Name = "Blastoise",
                Height = "5' 3\"",
                Id = 9,
                WhereItsFound = "Can only be obtained through evolution",
                PokedexEntry = "A brutal Pokémon with pressurized water jets on its shell. They are used for high speed tackles.",
                Weight = 189.0f,
                LevelEvolve = null,
                Evolutions = new List<string>
                {
                    "Squirtle",
                    "Blastoise"
                },
                Type = new List<PokemonType>
                {
                    new PokemonType
                    {
                        Name = "Water",
                        Weaknesses = new List<string>
                        {
                            "Grass"
                        }
                    }
                },
                Moves = new List<PokemonMove>
                {
                    new PokemonMove
                    {
                        Name = "Skull Bash",
                        Type = "Normal",
                        LevelGained = 42,
                        GenerationMoveFirstAppearedIn = 1
                    },
                    new PokemonMove
                    {
                        Name = "Hydro Pump",
                        Type = "Water",
                        LevelGained = 52,
                        GenerationMoveFirstAppearedIn = 1
                    }
                }
            };
            context.Pokemons.AddOrUpdate(s => s.Id, blastoise);

            var caterpie = new Pokemon
            {
                Name = "Caterpie",
                Id = 10,
                Height = "1' 0\"",
                WhereItsFound = "Route 2, Viridian Forest, Route 24, Route 25",
                PokedexEntry = "Its short feet are tipped with suction pads that enable it to tirelessly climb slopes and walls",
                Weight = 6.0f,
                LevelEvolve = 7,
                Evolutions = new List<string>
                {
                    "Metapod",
                    "Butterfree"
                },
                Type = new List<PokemonType>
                {
                    new PokemonType
                    {
                        Name = "Bug",
                        Weaknesses = new List<string>
                        {
                            "Grass"
                        }
                    }
                },
                Moves = new List<PokemonMove>
                {
                    new PokemonMove
                    {
                        Name = "Tackle",
                        Type = "Normal",
                        LevelGained = 1,
                        GenerationMoveFirstAppearedIn = 1
                    },
                    new PokemonMove
                    {
                        Name = "String Shot",
                        Type = "Bug",
                        LevelGained = 1,
                        GenerationMoveFirstAppearedIn = 1
                    }
                }
            };
            context.Pokemons.AddOrUpdate(s => s.Id, caterpie);

            var metapod = new Pokemon
            {
                Name = "Metapod",
                Id = 11,
                Height = "2' 4\"",
                WhereItsFound = "Viridian Forest, Route 24, Route 25",
                PokedexEntry = "This Pokémon is vulnerable to attack while its shell is soft, exposing its weak and tender body.",
                Weight = 22.0f,
                LevelEvolve = 10,
                Evolutions = new List<string>
                {
                    "Butterfree"
                },
                Type = new List<PokemonType>
                {
                    new PokemonType
                    {
                        Name = "Bug",
                        Weaknesses = new List<string>
                        {
                            "Grass"
                        }
                    }
                },
                Moves = new List<PokemonMove>
                {
                    new PokemonMove
                    {
                        Name = "Harden",
                        Type = "Normal",
                        LevelGained = 7,
                        GenerationMoveFirstAppearedIn = 1
                    }
                }
            };
            context.Pokemons.AddOrUpdate(s => s.Id, metapod);

            var butterfree = new Pokemon
            {
                Name = "Butterfree",
                Id = 12,
                Height = "3' 7\"",
                WhereItsFound = "Can only be obtained in Viridian Forest",
                PokedexEntry = "In battle, it flaps its wings at high speed to release highly toxic dust into the air.",
                Weight = 71.0f,
                LevelEvolve = null,
                Evolutions = new List<string>
                {
                    "Caterpie",
                    "Metapod"
                },
                Type = new List<PokemonType>
                {
                    new PokemonType
                    {
                        Name = "Bug",
                        Weaknesses = new List<string>
                        {
                            "Grass"
                        }
                    }
                },
                Moves = new List<PokemonMove>
                {
                    new PokemonMove
                    {
                        Name = "Confusion",
                        Type = "Psychic",
                        LevelGained = 10,
                        GenerationMoveFirstAppearedIn = 1
                    },
                    new PokemonMove
                    {
                        Name = "Poison Powder",
                        Type = "Poison",
                        LevelGained = 13,
                        GenerationMoveFirstAppearedIn = 1
                    },
                    new PokemonMove
                    {
                        Name = "Stun Spore",
                        Type = "Grass",
                        LevelGained = 14,
                        GenerationMoveFirstAppearedIn = 1
                    },
                    new PokemonMove
                    {
                        Name = "Sleep Powder",
                        Type = "Grass",
                        LevelGained = 15,
                        GenerationMoveFirstAppearedIn = 1
                    },
                    new PokemonMove
                    {
                        Name = "Supersonic",
                        Type = "Normal",
                        LevelGained = 18,
                        GenerationMoveFirstAppearedIn = 1
                    },
                    new PokemonMove
                    {
                        Name = "Whirlwind",
                        Type = "Normal",
                        LevelGained = 23,
                        GenerationMoveFirstAppearedIn = 1
                    },
                    new PokemonMove
                    {
                        Name = "Psybeam",
                        Type = "Psychic",
                        LevelGained = 34,
                        GenerationMoveFirstAppearedIn = 1
                    }
                }
            };
            context.Pokemons.AddOrUpdate(s => s.Id, butterfree);









        }
    }
}
