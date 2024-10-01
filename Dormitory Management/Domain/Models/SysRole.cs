using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class SysRole
{
    public int RoleId { get; set; }

    public string? RoleCode { get; set; }

    public string? RoleName { get; set; }

    public virtual ICollection<SysAccount> Accounts { get; set; } = new List<SysAccount>();

    public virtual ICollection<SysPermission> Permissions { get; set; } = new List<SysPermission>();
}
