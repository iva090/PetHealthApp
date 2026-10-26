using Data.Interfaces;
using PetHealth.Data.Entities;
using PetHealth.Domain.Entities;

namespace PetHealth.Data.Data;

public class UnitOfWork : IUnitOfWork
{
    private readonly PetAppContext _context;

    public IRepository<Pet> Pets { get; }
    public IRepository<DietPlan> DietPlans { get; }
    public IRepository<Vaccine> Vaccines { get; }
    public IRepository<VetVisit> VetVisits { get; }
    public IRepository<ChatMessage> ChatMessages { get; }

    public UnitOfWork(PetAppContext context)
    {
        _context = context;
        Pets = new Repository<Pet>(_context);
        DietPlans = new Repository<DietPlan>(_context);
        Vaccines = new Repository<Vaccine>(_context);
        VetVisits = new Repository<VetVisit>(_context);
        ChatMessages = new Repository<ChatMessage>(_context);
    }

    public async Task<int> CompleteAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
        GC.SuppressFinalize(this);
    }
}