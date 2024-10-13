using Domain.Model;
using Infrastructure.Repositories;

namespace Infrastructure.Abstractions.IRepository;

public interface IFacRoomItemRepository : IGenericRepository<FacRoomItem>
{
    //Task<IEnumerable<FacRoomItem>> Get();
    //void Create(FacRoomItem facRoomItem);
    //void Update(FacRoomItem facRoomItem);
    //void Delete(int roomId, int itemId);
}