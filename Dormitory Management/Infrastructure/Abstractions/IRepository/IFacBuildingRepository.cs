using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

public interface IFacBuildingRepository
{
    Task<IEnumerable<FacBuilding>> Get();

    Task<IEnumerable<FacBuilding>> Search(
        string name);

    void Create(FacBuilding facBuilding);
    void Update(FacBuilding facBuilding);
    void Delete(int id);
}