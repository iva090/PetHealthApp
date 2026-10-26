using Microsoft.EntityFrameworkCore;
using PetHealth.Data.Entities;
using PetHealth.Domain.Entities;

namespace PetHealth.Data.Data
{
    public class PetAppContext : DbContext
    {
        public PetAppContext(DbContextOptions<PetAppContext> options) 
            : base(options)
        {
            
        }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<DietPlan> DietPlans { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }
        public DbSet<VetVisit> VetVisits { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }

    }
}
