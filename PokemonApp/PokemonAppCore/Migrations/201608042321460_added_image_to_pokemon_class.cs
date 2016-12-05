namespace PokemonAppCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_image_to_pokemon_class : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pokemons", "PokemonImage", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pokemons", "PokemonImage");
        }
    }
}
