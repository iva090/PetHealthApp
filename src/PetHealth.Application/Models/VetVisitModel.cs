using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealth.Business.Models
{
    public class VetVisitModel
    {
        public Guid Id { get; set; }
        public Guid PetId { get; set; }
        public DateOnly VisitDate { get; set; }
        public string? ClinicName { get; set; }
        public string Reason { get; set; } = default!;
        public string? Diagnosis { get; set; }
        public string? Notes { get; set; }
    }
}
