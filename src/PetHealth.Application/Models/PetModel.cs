namespace PetHealth.Business.Models
{
    public class PetModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Species { get; set; } = string.Empty;
        public string Breed { get; set; } = string.Empty;
        public double WeightKg { get; set; }
        public int VaccineCount { get; set; }
    }
}
