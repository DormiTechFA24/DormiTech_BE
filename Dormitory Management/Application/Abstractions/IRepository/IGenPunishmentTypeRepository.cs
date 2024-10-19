using Domain.Model;

namespace Application.Abstractions.IRepository;

public interface IGenPunishmentTypeRepository
{
    Task<IEnumerable<GenPunishmentType>> GetAll();
    Task<GenPunishmentType> GetById(Guid id);
}