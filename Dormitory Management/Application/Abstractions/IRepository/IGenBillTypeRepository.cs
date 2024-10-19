using Domain.Model;

namespace Application.Abstractions.IRepository;

public interface IGenBillTypeRepository
{
    Task<IEnumerable<GenBillType>> GetAll();
    Task<GenBillType?> GetById(int id);
}