using Domain.Model;

namespace Domain.Abstractions.IRepository;

public interface IFacRoomItemRepository
{
    Task<IEnumerable<FacRoomItem>> Get();
    void Create(FacRoomItem facRoomItem);
    void Update(FacRoomItem facRoomItem);
    void Delete(int roomId, int iteamId);
}