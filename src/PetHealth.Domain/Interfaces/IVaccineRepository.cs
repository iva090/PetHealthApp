using Data.Interfaces;
using PetHealth.Domain.Entities;
namespace PetHealth.Data.Interfaces
{
    public interface IVaccineRepository : IRepository<Vaccine>
    {
        Task<IEnumerable<Vaccine>> GetByPetAsync(Guid petId);
        Task<IEnumerable<Vaccine>> GetDueAsync(string ownerId, DateOnly dueBy);
    }
}
