namespace PetHealth.Business.Models
{
    public class DietPlanModel
    {
        public Guid Id { get; set; }
        public Guid PetId { get; set; }
        public string FoodName { get; set; } = string.Empty;
        public string? Brand { get; set; }
        public int? DailyAmountGrams { get; set; }
        public int MealsPerDay { get; set; }
        public string? Notes { get; set; }
    }
}
