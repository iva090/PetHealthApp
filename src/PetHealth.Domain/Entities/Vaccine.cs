using PetHealth.Domain.Common;

namespace PetHealth.Domain.Entities
{
    public class Vaccine : BaseEntity
    {
        public Guid PetId { get; set; }
        public string Name { get; set; } = default!;
        public DateOnly DateGiven { get; set; }
        public DateOnly? NextDueDate { get; set; }
        public string? Notes { get; set; }
    }
}
