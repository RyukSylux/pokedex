namespace PokedexApp
{

    public class Pokemon
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Region { get; set; }
        public string AtqSign { get; set; }
        public string Type { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public bool IsCaptured { get; set; }
        public bool CanEvolve {get; set; }
        public string Weakness { get; set; }
        public string ImagePath { get; set; } // Chemin de l'image
        
      
        public override string ToString()
        {
            return $"{ID}: {Name} ({Type}) - Captured: {IsCaptured}";
        }
    }
}
