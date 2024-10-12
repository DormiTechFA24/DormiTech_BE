using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

public interface IGenProvinceRepository
{
    Task<IEnumerable<GenProvince>> GetAll();
    Task<GenProvince> GetById(Guid id);
}