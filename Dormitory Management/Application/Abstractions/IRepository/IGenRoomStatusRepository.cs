using Domain.Model;

namespace Application.Abstractions.IRepository;

public interface IGenRoomStatusRepository
{
    Task<IEnumerable<GenRoomStatus>> GetAll();
    Task<GenRoomStatus> GetById(Guid id);
}