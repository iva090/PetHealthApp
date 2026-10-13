namespace PetHealth.Domain.Entities
{
    public class DietPlan
    {
        public Guid PetId { get; set; }
        public string FoodName { get; set; } = default!;
        public string? Brand { get; set; }
        public int? DailyAmountGrams { get; set; }
        public int MealsPerDay { get; set; }
        public string? Notes { get; set; }
    }
}
