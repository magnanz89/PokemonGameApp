namespace PokemonAppCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PokemonMoves", "GenerationMoveFirstAppearedIn", c => c.Int(nullable: false));
            AlterColumn("dbo.PokemonMoves", "Damage", c => c.Int(nullable: false));
            DropColumn("dbo.PokemonMoves", "GameFirstAppearedIn");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PokemonMoves", "GameFirstAppearedIn", c => c.String());
            AlterColumn("dbo.PokemonMoves", "Damage", c => c.String());
            DropColumn("dbo.PokemonMoves", "GenerationMoveFirstAppearedIn");
        }
    }
}
