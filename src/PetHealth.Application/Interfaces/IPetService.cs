using PetHealth.Business.Models;
using System.Threading.Tasks;

namespace PetHealth.Business.Interfaces
{
    public interface IPetService
    {
        Task<IReadOnlyList<PetModel>> GetMyPetsAsync();
        Task<PetModel> GetByIdAsync(Guid petId);
        Task<PetModel> CreateAsync(PetModel model);
        Task<PetModel> UpdateAsync(Guid petId, PetModel model);
        Task DeleteAsync(Guid petId);
    }
}
