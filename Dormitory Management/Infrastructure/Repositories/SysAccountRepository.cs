using Domain.Abstractions.IRepository;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public sealed class SysAccountRepository : ISysAccountRepository
{
    private readonly DbSet<SysAccount> context;

    public SysAccountRepository(DormiTechContext context)
    {
        this.context = context.Set<SysAccount>();
    }

    public void Create(SysAccount sysAccount)
    {
        context.Add(sysAccount);
    }

    public void Delete(Guid Id)
    {
        context
            .Where(a => a.AccountId == Id)
            .ExecuteDelete();
    }

    public async Task<IEnumerable<SysAccount>> Get()
    {
        IQueryable<SysAccount> query = context;

        return query;
    }

    public async Task<IEnumerable<SysAccount>> Search(string email = "")
    {
        IQueryable<SysAccount> query = context;

        return query;
    }

    public void Update(SysAccount sysAccount)
    {
        context.Update(sysAccount);
    }
}
