using Application.Common;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public class PermissionRepository : Repository<Permission>
{
    protected override DbSet<Permission> DbSet => Context.Permissions;

    public PermissionRepository(IApplicationDbContext context) : base(context)
    {
    }
}
