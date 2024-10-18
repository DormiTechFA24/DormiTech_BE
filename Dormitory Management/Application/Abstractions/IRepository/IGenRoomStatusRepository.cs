using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

public interface IGenRoomStatusRepository
{
    Task<IEnumerable<GenRoomStatus>> GetAll();
    Task<GenRoomStatus> GetById(Guid id);
}