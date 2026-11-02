using Data.Interfaces;
using PetHealth.Domain.Entities;

namespace PetHealth.Data.Interfaces
{
    public interface IVetVisitRepository : IRepository<VetVisit>
    {
        Task<IEnumerable<VetVisit>> GetByPetAsync(Guid petId);

        Task<IEnumerable<VetVisit>> GetRecentAsync(Guid petId, int count);
    }
}
