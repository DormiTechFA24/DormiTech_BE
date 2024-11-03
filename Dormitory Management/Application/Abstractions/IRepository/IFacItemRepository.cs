using Domain.Model;

namespace Application.Abstractions.IRepository;

public interface IFacItemRepository : IGenericRepository<FacItem>
{
    //Task<IEnumerable<FacItem>> Get();

    //Task<IEnumerable<FacItem>> Search(
    //    string name = "",
    //    decimal min = 0,
    //    decimal max = 0);

    //void Create(FacItem facItem);
    //void Update(FacItem facItem);
    //void Delete(int Id);
}