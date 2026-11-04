using PetHealth.Business.Models;

namespace PetHealth.Business.Interfaces
{
    public interface IVetVisitService
    {
        Task<IEnumerable<VetVisitModel>> GetByPetAsync(Guid petId);

        Task<IEnumerable<VetVisitModel>> GetRecentAsync(Guid petId, int count);
        Task<VetVisitModel> CreateAsync(VetVisitModel model);
        Task<VetVisitModel> UpdateAsync(Guid id, VetVisitModel model);
        Task DeleteAsync(Guid id);
    }
}
