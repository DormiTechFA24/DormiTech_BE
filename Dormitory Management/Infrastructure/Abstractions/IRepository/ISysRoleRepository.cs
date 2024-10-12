using Domain.Model;

namespace Infrastructure.Abstractions.IRepository;

public interface ISysRoleRepository
{
    Task<IEnumerable<SysRole>> Get();
    void Create(SysRole sysRole);
    void Update(SysRole sysRole);
    void Delete(int Id);
}