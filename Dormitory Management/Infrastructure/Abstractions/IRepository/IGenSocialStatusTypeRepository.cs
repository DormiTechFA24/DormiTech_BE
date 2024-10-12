using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

public interface IGenSocialStatusTypeRepository
{
    Task<IEnumerable<GenSocialStatusType>> GetAll();
    Task<GenSocialStatusType> GetById(Guid id);
}