using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

public interface ISysDocumentSetUpRepository
{
    void Create(SysDocumentSetUp sysDocumentSetUp);
    Task Delete(int id);
    Task<IEnumerable<SysDocumentSetUp>> Get();
    Task<IEnumerable<SysDocumentSetUp>> Search(string email = "");
    void Update(SysDocumentSetUp sysDocumentSetUp);
    Task<SysDocumentSetUp?> GetById(int id);
}