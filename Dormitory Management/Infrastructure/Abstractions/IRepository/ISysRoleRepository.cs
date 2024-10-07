using Domain.Model;

namespace Domain.Abstractions.IRepository;

public interface ISysRoleRepository
{
    Task<IEnumerable<SysRole>> Get();
    void Create(SysRole sysRole);
    void Update(SysRole sysRole);
    void Delete(int Id);
}