using Domain.Model;

namespace Domain.Abstractions.IRepository;

public interface ISysAccountRepository
{
    Task<IEnumerable<SysAccount>> Get();
    Task<IEnumerable<SysAccount>> Search(
        string email = "");
    void Create(SysAccount sysAccount);
    void Update(SysAccount sysAccount);
    void Delete(Guid Id);
}