using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

public interface IGenItemStatusRepository
{
    Task<IEnumerable<GenItemStatus>> GetAll();
    Task<GenItemStatus> GetById(Guid id);
}