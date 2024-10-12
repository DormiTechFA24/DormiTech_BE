using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

public interface IGenDistanceTypeRepository
{
    Task<IEnumerable<GenDistanceType>> GetAll();
    Task<GenDistanceType?> GetById(int id);
}