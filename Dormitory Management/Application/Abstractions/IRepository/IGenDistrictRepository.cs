using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

public interface IGenDistrictRepository
{
    Task<IEnumerable<GenDistrict>> GetAll();
    Task<GenDistrict?> GetById(int id);
}