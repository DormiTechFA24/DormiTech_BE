using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

public interface IGenRoomTypeRepository
{
    Task<IEnumerable<GenRoomType>> GetAll();
    Task<GenRoomType> GetById(Guid id);
}