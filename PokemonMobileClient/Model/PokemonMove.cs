namespace PokemonMobileClient.Model
{
    public class PokemonMove
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int GenerationMoveFirstAppearedIn { get; set; }
        public int? LevelGained { get; set; }
        public string Type { get; set; }
    }
}