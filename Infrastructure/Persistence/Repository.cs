using Application.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    protected readonly IApplicationDbContext Context;
    protected abstract DbSet<TEntity> DbSet { get; }

    public Repository(IApplicationDbContext context)
    {
        Context = context;
    }

    public IQueryable<TEntity> GetAll()
    {
        return DbSet.AsNoTracking().AsQueryable();
    }

    public Task<TEntity> AddAsync()
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync()
    {
        throw new NotImplementedException();
    }
}
