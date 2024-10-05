using Domain.Model;

namespace Domain.Abstractions.IRepository;

public interface IFacItemRepository
{
    Task<IEnumerable<FacItem>> Get();
    Task<IEnumerable<FacItem>> Search(
        string name = "",
        decimal min = 0,
        decimal max = 0);
    void Create(FacItem facItem);
    void Update(FacItem facItem);
    void Delete(int Id);
}