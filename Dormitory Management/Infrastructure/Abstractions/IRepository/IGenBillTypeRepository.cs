using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

public interface IGenBillTypeRepository
{
    Task<IEnumerable<GenBillType>> GetAll();
    Task<GenBillType?> GetById(int id);
}