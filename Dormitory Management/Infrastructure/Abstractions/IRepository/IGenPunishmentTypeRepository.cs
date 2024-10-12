using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

public interface IGenPunishmentTypeRepository
{
    Task<IEnumerable<GenPunishmentType>> GetAll();
    Task<GenPunishmentType> GetById(Guid id);
}