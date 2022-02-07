namespace Application.Common;

public interface IRepository<TEntity>
{
    IQueryable<TEntity> GetAll();
    Task<TEntity> AddAsync();
    Task UpdateAsync();
    Task DeleteAsync();
}
