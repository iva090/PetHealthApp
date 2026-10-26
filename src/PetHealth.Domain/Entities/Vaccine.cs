using PetHealth.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
