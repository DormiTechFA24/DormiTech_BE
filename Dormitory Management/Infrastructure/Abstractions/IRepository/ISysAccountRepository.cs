using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

public interface ISysAccountRepository
{
    Task<IEnumerable<SysAccount>> Get();

    Task<IEnumerable<SysAccount>> Search(
        string email = "");

    void Create(SysAccount sysAccount);
    void Update(SysAccount sysAccount);
    void Delete(Guid id);
}