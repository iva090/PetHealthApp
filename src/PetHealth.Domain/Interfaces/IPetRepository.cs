using Data.Interfaces;
using PetHealth.Domain.Entities;

namespace PetHealth.Data.Interfaces
{
    public interface IPetRepository : IRepository<Pet>
    {
        Task<IEnumerable<Pet>> GetByOwnerAsync(string ownerId);

        Task<Pet?> GetWithDetailsAsync(Guid petId);
    }
}
