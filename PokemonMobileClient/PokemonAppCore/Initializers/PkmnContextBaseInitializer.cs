using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using PokemonAppCore.Models;

namespace PokemonAppCore.Initializers
{
    public class PkmnContextBaseInitializer : DropCreateDatabaseAlways<PkmnContext>
    {
        protected override void Seed(PkmnContext context)
        {
            

        }
    }
}