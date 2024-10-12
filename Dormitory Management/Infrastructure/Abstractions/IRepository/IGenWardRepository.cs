using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

public interface IGenWardRepository
{
    Task<IEnumerable<GenWard>> GetAll();
    Task<GenWard> GetById(Guid id);
}