using Domain.Model;

namespace Application.Abstractions.IRepository;

public interface IGenPayTypeRepository
{
    Task<IEnumerable<GenPayType>> GetAll();
    Task<GenPayType> GetById(Guid id);
}