using Domain.Abstractions.IRepository;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public sealed class BilBillingRepository : IBilBillingRepository
{
    private readonly DbSet<BilBilling> context;

    public BilBillingRepository(DormiTechContext context)
    {
        this.context = context.Set<BilBilling>();
    }

    public void Create(BilBilling bilBilling)
    {
        context.Add(bilBilling);
    }

    public async Task<IEnumerable<BilBilling>> Get()
    {
        IQueryable<BilBilling> query = context;

        return query;
    }

    public async Task<IEnumerable<BilBilling>> Search(Guid? student)
    {
        IQueryable<BilBilling> query = context;

        return query;
    }

    public void Update(BilBilling bilBilling)
    {
        context.Update(bilBilling);
    }
}
