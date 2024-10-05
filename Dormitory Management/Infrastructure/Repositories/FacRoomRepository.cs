using Domain.Abstractions.IRepository;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public sealed class FacRoomRepository : IFacRoomRepository
{
    private readonly DbSet<FacRoom> context;

    public FacRoomRepository(DormiTechContext context)
    {
        this.context = context.Set<FacRoom>();
    }

    public void Create(FacRoom facRoom)
    {
        context.Add(facRoom);
    }

    public void Delete(int id)
    {
        context
            .Where(r => r.RoomId == id)
            .ExecuteDelete();
    }

    public async Task<FacRoom> Detail(Guid id)
    {
        IQueryable<FacRoom> query = context;

        return await query.FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<FacRoom>> Get()
    {
        IQueryable<FacRoom> query = context;

        return query;
    }

    public async Task<IEnumerable<FacRoom>> Search(int floor = 0)
    {
        IQueryable<FacRoom> query = context;

        return query;
    }

    public void Update(FacRoom facRoom)
    {
        context.Update(facRoom);
    }
}