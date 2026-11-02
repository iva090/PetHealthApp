using Data.Interfaces;
using PetHealth.Domain.Entities;

namespace PetHealth.Data.Interfaces
{
    public interface IDietPlanRepository : IRepository<DietPlan>
    {
        Task<IEnumerable<DietPlan>> GetByPetAsync(Guid petId);
    }
}
