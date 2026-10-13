using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealth.Domain.Entities
{
    internal class Vaccine
    {
        public Guid PetId { get; set; }
        public string Name { get; set; } = default!;
        public DateOnly DateGiven { get; set; }
        public DateOnly? NextDueDate { get; set; }
        public string? Notes { get; set; }
    }
}
