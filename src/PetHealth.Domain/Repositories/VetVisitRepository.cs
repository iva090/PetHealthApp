using Microsoft.EntityFrameworkCore;
using PetHealth.Data.Data;
using PetHealth.Data.Interfaces;
using PetHealth.Domain.Entities;

namespace PetHealth.Data.Repositories
{
    public class VetVisitRepository : Repository<VetVisit>, IVetVisitRepository
    {
        public VetVisitRepository(PetAppContext context) : base(context)
        {
        }

        public async Task<IEnumerable<VetVisit>> GetByPetAsync(Guid petId)
        {
            return await _context.Set<VetVisit>()
                .Where(v => v.PetId == petId).ToListAsync();
        }

        public async Task<IEnumerable<VetVisit>> GetRecentAsync(Guid petId, int count)
        {
            return await _context.Set<VetVisit>()
                .Where(v => v.PetId == petId)
                .OrderByDescending(v => v.VisitDate)
                .ThenByDescending(v => v.CreatedAt)
                .Take(count)
                .ToListAsync();
        }
    }
}
