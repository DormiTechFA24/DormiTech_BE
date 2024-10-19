using Domain.Model;

namespace Application.Abstractions.IRepository;

public interface IGenEthnicityRepository
{
    Task<IEnumerable<GenEthnicity>> GetAll();
    Task<GenEthnicity> GetById(Guid id);
}