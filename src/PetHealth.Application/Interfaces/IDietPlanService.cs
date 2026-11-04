using PetHealth.Business.Models;

namespace PetHealth.Business.Interfaces
{
    public interface IDietPlanService
    {
        Task<IEnumerable<DietPlanModel>> GetByPetAsync(Guid petId);
        Task<DietPlanModel> CreateAsync(DietPlanModel model);
        Task<DietPlanModel> UpdateAsync(Guid id, DietPlanModel model);
        Task DeleteAsync(Guid id);
    }
}
