using Domain.Model;

namespace Application.Abstractions.IRepository;

public interface IGenDistrictRepository
{
    Task<IEnumerable<GenDistrict>> GetAll();
    Task<GenDistrict?> GetById(int id);
}