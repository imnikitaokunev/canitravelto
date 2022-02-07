using System.Reflection;
using Application.Common;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public DbSet<Country> Countries { get; set; }
    public DbSet<Citizen> Citizens { get; set; }
    public DbSet<Rule> Rules { get; set; }
    public DbSet<Permission> Permissions { get; set; }

    //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    //{
    //}

    public async Task<int> SaveChangesAsync()
    {
        return await base.SaveChangesAsync();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(local);Database=canitravelto;");
    }
}
