using Domain.Model;

namespace Application.Abstractions.IRepository;

public interface IGenEmployeePositionRepository
{
    Task<IEnumerable<GenEmployeePosition>> GetAll();
    Task<GenEmployeePosition> GetById(Guid id);
}