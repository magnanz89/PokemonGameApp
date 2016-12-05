namespace PokemonAppCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_more_to_pokemonmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PokemonMoves", "LevelGained", c => c.Int(nullable: false));
            AddColumn("dbo.PokemonMoves", "Type", c => c.String());
            AddColumn("dbo.Pokemons", "PokedexEntry", c => c.String());
            AddColumn("dbo.Pokemons", "Weight", c => c.Single(nullable: false));
            AddColumn("dbo.Pokemons", "Height", c => c.String());
            AddColumn("dbo.Pokemons", "WhereItsFound", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pokemons", "WhereItsFound");
            DropColumn("dbo.Pokemons", "Height");
            DropColumn("dbo.Pokemons", "Weight");
            DropColumn("dbo.Pokemons", "PokedexEntry");
            DropColumn("dbo.PokemonMoves", "Type");
            DropColumn("dbo.PokemonMoves", "LevelGained");
        }
    }
}
