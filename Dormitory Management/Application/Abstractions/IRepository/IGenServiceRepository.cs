using Domain.Model;

namespace Application.Abstractions.IRepository;

public interface IGenServiceRepository
{
    Task<IEnumerable<GenService>> GetAll();
    Task<GenService> GetById(Guid id);
}