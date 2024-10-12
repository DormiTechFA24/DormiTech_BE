using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

public interface IGenServiceRepository
{
    Task<IEnumerable<GenService>> GetAll();
    Task<GenService> GetById(Guid id);
}