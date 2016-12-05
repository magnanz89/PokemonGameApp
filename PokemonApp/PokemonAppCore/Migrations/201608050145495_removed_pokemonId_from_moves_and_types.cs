namespace PokemonAppCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removed_pokemonId_from_moves_and_types : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.PokemonMoves", name: "PokemonId_Id", newName: "Pokemon_Id");
            RenameColumn(table: "dbo.PokemonTypes", name: "PokemonId_Id", newName: "Pokemon_Id");
            RenameIndex(table: "dbo.PokemonMoves", name: "IX_PokemonId_Id", newName: "IX_Pokemon_Id");
            RenameIndex(table: "dbo.PokemonTypes", name: "IX_PokemonId_Id", newName: "IX_Pokemon_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.PokemonTypes", name: "IX_Pokemon_Id", newName: "IX_PokemonId_Id");
            RenameIndex(table: "dbo.PokemonMoves", name: "IX_Pokemon_Id", newName: "IX_PokemonId_Id");
            RenameColumn(table: "dbo.PokemonTypes", name: "Pokemon_Id", newName: "PokemonId_Id");
            RenameColumn(table: "dbo.PokemonMoves", name: "Pokemon_Id", newName: "PokemonId_Id");
        }
    }
}
