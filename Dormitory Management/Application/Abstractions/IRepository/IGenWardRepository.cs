using Domain.Model;

namespace Application.Abstractions.IRepository;

public interface IGenWardRepository
{
    Task<IEnumerable<GenWard>> GetAll();
    Task<GenWard> GetById(Guid id);
}