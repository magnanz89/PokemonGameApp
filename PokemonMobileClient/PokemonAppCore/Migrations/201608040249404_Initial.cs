namespace PokemonAppCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PokemonMoves",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Damage = c.String(),
                        GameFirstAppearedIn = c.String(),
                        PokemonId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pokemons", t => t.PokemonId_Id)
                .Index(t => t.PokemonId_Id);
            
            CreateTable(
                "dbo.Pokemons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LevelEvolve = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PokemonTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PokemonId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pokemons", t => t.PokemonId_Id)
                .Index(t => t.PokemonId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PokemonTypes", "PokemonId_Id", "dbo.Pokemons");
            DropForeignKey("dbo.PokemonMoves", "PokemonId_Id", "dbo.Pokemons");
            DropIndex("dbo.PokemonTypes", new[] { "PokemonId_Id" });
            DropIndex("dbo.PokemonMoves", new[] { "PokemonId_Id" });
            DropTable("dbo.PokemonTypes");
            DropTable("dbo.Pokemons");
            DropTable("dbo.PokemonMoves");
        }
    }
}
