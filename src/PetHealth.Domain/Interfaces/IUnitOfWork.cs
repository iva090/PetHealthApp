using PetHealth.Data.Entities;
using PetHealth.Data.Interfaces;
using PetHealth.Domain.Entities;

namespace Data.Interfaces;

public interface IUnitOfWork
{
    IPetRepository Pets { get; }
    IVaccineRepository Vaccines { get; }
    IVetVisitRepository VetVisits { get; }
    IDietPlanRepository DietPlans { get; }
    IChatMessageRepository ChatMessages { get; }

    Task<int> SaveChangesAsync(CancellationToken ct = default);
}