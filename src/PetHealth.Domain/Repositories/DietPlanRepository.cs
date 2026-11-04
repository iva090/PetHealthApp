using Microsoft.EntityFrameworkCore;
using PetHealth.Data.Data;
using PetHealth.Data.Interfaces;
using PetHealth.Domain.Entities;

namespace PetHealth.Data.Repositories
{
    public class DietPlanRepository : Repository<DietPlan>, IDietPlanRepository
    {
        public DietPlanRepository(PetAppContext context) : base(context) { }
        public async Task<IEnumerable<DietPlan>> GetByPetAsync(Guid petId)
        {
            return await _context.Set<DietPlan>().Where(d => d.PetId ==  petId).OrderByDescending(d => d.CreatedAt).ToListAsync();
        }
    }
}
