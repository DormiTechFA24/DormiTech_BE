using Domain.Model;

namespace Application.Abstractions.IRepository;

public interface IGenSocialStatusTypeRepository
{
    Task<IEnumerable<GenSocialStatusType>> GetAll();
    Task<GenSocialStatusType> GetById(Guid id);
}