using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

public interface IGenPayTypeRepository
{
    Task<IEnumerable<GenPayType>> GetAll();
    Task<GenPayType> GetById(Guid id);
}