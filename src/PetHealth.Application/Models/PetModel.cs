namespace PetHealth.Business.Models
{
    public class PetModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Species { get; set; } = string.Empty;
        public string Breed { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }

        public List<VaccineModel> Vaccines { get; set; } = [];
        public List<VetVisitModel> VetVisits { get; set; } = [];
        public List<DietPlanModel> DietPlans { get; set; } = [];
    }
}
