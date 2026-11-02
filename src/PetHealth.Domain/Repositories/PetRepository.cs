using Microsoft.EntityFrameworkCore;
using PetHealth.Data.Data;
using PetHealth.Data.Interfaces;
using PetHealth.Domain.Entities;

namespace PetHealth.Data.Repositories
{
    public class PetRepository : Repository<Pet>, IPetRepository
    {
        public PetRepository(PetAppContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<Pet>> GetByOwnerAsync(string ownerId)
        {
            return await _context.Set<Pet>()
                .Where(p => p.OwnerId == ownerId)
                .ToListAsync();
        }

        public async Task<Pet?> GetWithDetailsAsync(Guid petId)
        {
            return await _context.Set<Pet>()
                .Where(p => p.Id == petId)
                .Include(p => p.Vaccines)
                .Include(p => p.VetVisits)
                .Include(p => p.DietPlans)
                .FirstOrDefaultAsync();
        }
    }
}
