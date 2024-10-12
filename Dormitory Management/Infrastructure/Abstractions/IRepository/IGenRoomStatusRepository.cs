using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

internal interface IGenRoomStatusRepository
{
    Task<IEnumerable<GenRoomStatus>> GetAll();
    Task<GenRoomStatus> GetById(Guid id);
}