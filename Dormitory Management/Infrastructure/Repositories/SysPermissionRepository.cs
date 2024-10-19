using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;

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