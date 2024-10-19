using Domain.Model;

namespace Application.Abstractions.IRepository;

public interface IGenProvinceRepository
{
    Task<IEnumerable<GenProvince>> GetAll();
    Task<GenProvince> GetById(Guid id);
}