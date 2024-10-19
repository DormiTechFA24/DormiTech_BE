using Domain.Model;

namespace Application.Abstractions.IRepository;

public interface IGenModuleTypeRepository
{
    Task<IEnumerable<GenModuleType>> GetAll();
    Task<GenModuleType> GetById(Guid id);
}