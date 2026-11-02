using Microsoft.EntityFrameworkCore;
using PetHealth.Data.Data;
using PetHealth.Data.Interfaces;
using PetHealth.Domain.Entities;

namespace PetHealth.Data.Repositories
{
    public class VaccineRepository : Repository<Vaccine>, IVaccineRepository
    {
        public VaccineRepository(PetAppContext context) : base(context) { }

        public async Task<IEnumerable<Vaccine>> GetByPetAsync(Guid petId)
        {
            return await _context.Set<Vaccine>()
                .Where(v => v.PetId == petId)
                .OrderByDescending(v => v.DateGiven)
                .ToListAsync();
        }

        public async Task<IEnumerable<Vaccine>> GetDueAsync(string ownerId, DateOnly dueBy)
        {
            var ownerPetIds = _context.Set<Pet>()
                .Where(p => p.OwnerId == ownerId)
                .Select(p => p.Id);

            return await _context.Set<Vaccine>()
                .Where(v => v.NextDueDate != null && v.NextDueDate <= dueBy && ownerPetIds.Contains(v.PetId)).OrderBy(v => v.NextDueDate).ToListAsync();
        }
    }
}
