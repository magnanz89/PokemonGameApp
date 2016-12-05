namespace PokemonAppCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_nullableInt_toLevel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pokemons", "LevelEvolve", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pokemons", "LevelEvolve", c => c.Int(nullable: false));
        }
    }
}
