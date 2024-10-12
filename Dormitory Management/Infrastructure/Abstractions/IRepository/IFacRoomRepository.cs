using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

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