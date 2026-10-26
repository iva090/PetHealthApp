using Data.Interfaces;
using PetHealth.Domain.Common;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace PetHealth.Data.Data;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    protected readonly PetAppContext _context;

    public Repository(PetAppContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync() =>
        await _context.Set<TEntity>().ToListAsync();

    public async Task<TEntity?> GetByIdAsync(int id) =>
        await _context.Set<TEntity>().FindAsync(id);

    public async Task AddAsync(TEntity entity) =>
        await _context.Set<TEntity>().AddAsync(entity);

    public void Update(TEntity entity) =>
        _context.Set<TEntity>().Update(entity);

    public void Delete(TEntity entity) =>
        _context.Set<TEntity>().Remove(entity);

    public async Task DeleteByIdAsync(int id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            Delete(entity);
        }
    }

    public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate) =>
        await _context.Set<TEntity>().Where(predicate).ToListAsync();
}