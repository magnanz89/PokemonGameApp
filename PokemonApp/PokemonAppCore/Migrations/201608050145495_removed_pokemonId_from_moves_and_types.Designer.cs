// <auto-generated />
namespace PokemonAppCore.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class removed_pokemonId_from_moves_and_types : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(removed_pokemonId_from_moves_and_types));
        
        string IMigrationMetadata.Id
        {
            get { return "201608050145495_removed_pokemonId_from_moves_and_types"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
