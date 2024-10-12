using Domain.Model;
using Infrastructure.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public sealed class SysPermissionRepository : ISysPermissionRepository
{
    private readonly DbSet<SysPermission> context;

    public SysPermissionRepository(DormiTechContext context)
    {
        this.context = context.Set<SysPermission>();
    }

    public async Task<IEnumerable<SysPermission>> Get()
    {
        IQueryable<SysPermission> query = context;

        return query;
    }

    public async Task<IEnumerable<SysPermission>> Search(string permissionCode)
    {
        IQueryable<SysPermission> query = context;

        return query;
    }
}