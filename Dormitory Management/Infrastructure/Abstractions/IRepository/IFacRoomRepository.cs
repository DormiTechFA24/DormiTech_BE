using Domain.Model;

namespace Domain.Abstractions.IRepository;

public interface IFacRoomRepository
{
    Task<IEnumerable<FacRoom>> Get();
    Task<IEnumerable<FacRoom>> Search(
        int floor = 0);
    Task<FacRoom> Detail(Guid id);
    void Create(FacRoom facRoom);
    void Update(FacRoom facRoom);
    void Delete(int id);
}