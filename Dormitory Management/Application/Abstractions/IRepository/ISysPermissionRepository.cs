using Domain.Model;

namespace Application.Abstractions.IRepository;

public interface ISysPermissionRepository
{
    Task<IEnumerable<SysPermission>> Get();
    Task<IEnumerable<SysPermission>> Search(string permissionCode);
}