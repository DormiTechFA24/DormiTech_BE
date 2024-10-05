using Domain.Abstractions.IRepository;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public sealed class FacItemRepository : IFacItemRepository
{
    private readonly DbSet<FacItem> context;

    public FacItemRepository(DormiTechContext context)
    {
        this.context = context.Set<FacItem>();
    }

    public void Create(FacItem facItem)
    {
        context.Add(facItem);
    }

    public void Delete(int Id)
    {
        context
            .Where(i => i.ItemId == Id)
            .ExecuteDelete();
    }

    public async Task<IEnumerable<FacItem>> Get()
    {
        IQueryable<FacItem> query = context;

        return query;
    }

    public async Task<IEnumerable<FacItem>> Search(string name = "", decimal min = 0, decimal max = 0)
    {
        IQueryable<FacItem> query = context;

        return query;
    }

    public void Update(FacItem facItem)
    {
        context.Update(facItem);
    }
}
