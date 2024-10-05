using Domain.Abstractions.IRepository;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public sealed class SysRoleRepository : ISysRoleRepository
{
    private readonly DbSet<SysRole> context;

    public SysRoleRepository(DormiTechContext context)
    {
        this.context = context.Set<SysRole>();
    }

    public void Create(SysRole sysRole)
    {
        context.Add(sysRole);
    }

    public void Delete(int Id)
    {
        context
            .Where(r => r.RoleId == Id)
            .ExecuteDelete();
    }

    public async Task<IEnumerable<SysRole>> Get()
    {
        IQueryable<SysRole> query = context;

        return query;
    }

    public void Update(SysRole sysRole)
    {
        context.Update(sysRole);
    }
}
