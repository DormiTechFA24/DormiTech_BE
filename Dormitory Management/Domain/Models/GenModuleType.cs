using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class GenModuleType
{
    public int ModuleTypeId { get; set; }

    public string? ModuleName { get; set; }

    public virtual ICollection<SysDocumentSetUp> SysDocumentSetUps { get; set; } = new List<SysDocumentSetUp>();
}
