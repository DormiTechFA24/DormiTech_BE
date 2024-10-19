using Domain.Model;

namespace Application.Abstractions.IRepository;

public interface IGenDistanceTypeRepository
{
    Task<IEnumerable<GenDistanceType>> GetAll();
    Task<GenDistanceType?> GetById(int id);
}