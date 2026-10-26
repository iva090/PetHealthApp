using PetHealth.Domain.Common;

namespace PetHealth.Domain.Entities
{
    public class DietPlan : BaseEntity
    {
        public Guid PetId { get; set; }
        public string FoodName { get; set; } = default!;
        public string? Brand { get; set; }
        public int? DailyAmountGrams { get; set; }
        public int MealsPerDay { get; set; }
        public string? Notes { get; set; }
    }
}
