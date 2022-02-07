using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common;

public interface IApplicationDbContext
{
    DbSet<Country> Countries { get; }
    DbSet<Citizen> Citizens { get; }
    DbSet<Rule> Rules { get; }
    DbSet<Permission> Permissions { get; }

    Task<int> SaveChangesAsync();
}
