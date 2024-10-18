using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

public interface IGenEthnicityRepository
{
    Task<IEnumerable<GenEthnicity>> GetAll();
    Task<GenEthnicity> GetById(Guid id);
}