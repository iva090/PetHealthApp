using PetHealth.Data.Entities;
using PetHealth.Domain.Entities;

namespace Data.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IRepository<Pet> Pets { get; }
    IRepository<Vaccine> Vaccines { get; }
    IRepository<VetVisit> VetVisits { get; }
    IRepository<DietPlan> DietPlans { get; }
    IRepository<ChatMessage> ChatMessages { get; }

    Task<int> CompleteAsync();
}