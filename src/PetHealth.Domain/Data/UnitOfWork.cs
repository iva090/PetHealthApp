using Data.Interfaces;
using PetHealth.Data.Entities;
using PetHealth.Data.Interfaces;
using PetHealth.Data.Repositories;
using PetHealth.Domain.Entities;

namespace PetHealth.Data.Data;

public class UnitOfWork : IUnitOfWork
{
    private readonly PetAppContext _context;

    public IPetRepository Pets { get; }
    public IVaccineRepository Vaccines { get; }
    public IVetVisitRepository VetVisits { get; }
    public IDietPlanRepository DietPlans { get; }
    public IChatMessageRepository ChatMessages { get; }

    public UnitOfWork(PetAppContext context)
    {
        _context = context;

        Pets = new PetRepository(_context);
        Vaccines = new VaccineRepository(_context);
        VetVisits = new VetVisitRepository(_context);
        DietPlans = new DietPlanRepository(_context);
        ChatMessages = new ChatMessageRepository(_context);
    }

    public Task<int> SaveChangesAsync(CancellationToken ct = default)
        => _context.SaveChangesAsync(ct);
}