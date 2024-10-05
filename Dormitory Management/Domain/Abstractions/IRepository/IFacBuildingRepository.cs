using Domain.Model;

namespace Domain.Abstractions.IRepository;

public interface IFacBuildingRepository
{
    Task<IEnumerable<FacBuilding>> Get();
    Task<IEnumerable<FacBuilding>> Search(
        string name);
    void Create(FacBuilding facBuilding);
    void Update(FacBuilding facBuilding);
    void Delete(int Id);
}