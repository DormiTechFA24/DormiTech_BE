using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

public interface IFacRoomItemRepository
{
    Task<IEnumerable<FacRoomItem>> Get();
    void Create(FacRoomItem facRoomItem);
    void Update(FacRoomItem facRoomItem);
    void Delete(int roomId, int itemId);
}