using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

public interface IGenEmployeePositionRepository
{
    Task<IEnumerable<GenEmployeePosition>> GetAll();
    Task<GenEmployeePosition> GetById(Guid id);
}