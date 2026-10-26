namespace PetHealth.Business.Models
{
    public class VaccineModel
    {
        public int Id { get; set; }
        public Guid PetId { get; set; }
        public string Name { get; set; } = default!;
        public DateOnly DateGiven { get; set; }
        public DateOnly? NextDueDate { get; set; }
        public string? Notes { get; set; }
    }
}
