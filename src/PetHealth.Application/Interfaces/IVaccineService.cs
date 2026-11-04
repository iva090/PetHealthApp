using PetHealth.Business.Models;

namespace PetHealth.Business.Interfaces
{
    public interface IVaccineService
    {
        Task<IEnumerable<VaccineModel>> GetByPetAsync(Guid petId);
        Task<IEnumerable<VaccineModel>> GetUpcomingAsync(int withinDays);
        Task<VaccineModel> CreateAsync(VaccineModel model);
        Task<VaccineModel> UpdateAsync(Guid id, VaccineModel model);
        Task DeleteAsync(Guid id);
    }
}
