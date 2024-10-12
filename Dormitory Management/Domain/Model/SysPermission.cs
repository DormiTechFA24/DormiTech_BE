﻿namespace Domain.Model;

public partial class SysPermission
{
    public Guid PermissionId { get; set; }

    public string? PermissionName { get; set; }

    public virtual ICollection<SysRole> Roles { get; set; } = new List<SysRole>();
}