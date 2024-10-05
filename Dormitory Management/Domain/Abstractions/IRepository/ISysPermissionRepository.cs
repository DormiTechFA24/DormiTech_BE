using Domain.Model;

namespace Domain.Abstractions.IRepository;

public interface ISysPermissionRepository
{
    Task<IEnumerable<SysPermission>> Get();
    Task<IEnumerable<SysPermission>> Search(string permissionCode);
}