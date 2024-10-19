using Domain.Model;

namespace Application.Abstractions.IRepository;

public interface IGenItemStatusRepository
{
    Task<IEnumerable<GenItemStatus>> GetAll();
    Task<GenItemStatus> GetById(Guid id);
}