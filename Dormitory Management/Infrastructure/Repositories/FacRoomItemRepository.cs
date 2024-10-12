using Domain.Model;
using Infrastructure.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public sealed class FacRoomItemRepository : IFacRoomItemRepository
{
    private readonly DbSet<FacRoomItem> context;

    public FacRoomItemRepository(DormiTechContext context)
    {
        this.context = context.Set<FacRoomItem>();
    }

    public void Create(FacRoomItem facRoomItem)
    {
        context.Add(facRoomItem);
    }

    public void Delete(int roomId, int itemId)
    {
        context
            .Where(ri => ri.ItemId == itemId
                         && ri.RoomId == roomId)
            .ExecuteDelete();
    }

    public async Task<IEnumerable<FacRoomItem>> Get()
    {
        IQueryable<FacRoomItem> query = context;

        return query;
    }

    public void Update(FacRoomItem facRoomItem)
    {
        context.Update(facRoomItem);
    }
}