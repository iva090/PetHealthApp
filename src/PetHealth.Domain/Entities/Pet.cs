using PetHealth.Domain.Common;

namespace PetHealth.Domain.Entities
{
    public class Pet : BaseEntity
    {
        public string OwnerId { get; set; } = default!;
        public string Name { get; set; } = string.Empty;
        public string Species { get; set; } = string.Empty;
        public string Breed { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }

        public List<Vaccine> Vaccines { get; set; } = [];
        public List<VetVisit> VetVisits { get; set; } = [];
        public List<DietPlan> DietPlans { get; set; } = [];
    }
}
