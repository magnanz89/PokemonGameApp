namespace PokemonAppCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_nullableInt_pokemonMoves_levelGained : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PokemonMoves", "LevelGained", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PokemonMoves", "LevelGained", c => c.Int(nullable: false));
        }
    }
}
