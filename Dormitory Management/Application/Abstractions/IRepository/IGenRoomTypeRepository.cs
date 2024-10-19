using Domain.Model;

namespace Application.Abstractions.IRepository;

public interface IGenRoomTypeRepository
{
    Task<IEnumerable<GenRoomType>> GetAll();
    Task<GenRoomType> GetById(Guid id);
}