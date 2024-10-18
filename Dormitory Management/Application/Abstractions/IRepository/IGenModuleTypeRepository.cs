using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

public interface IGenModuleTypeRepository
{
    Task<IEnumerable<GenModuleType>> GetAll();
    Task<GenModuleType> GetById(Guid id);
}