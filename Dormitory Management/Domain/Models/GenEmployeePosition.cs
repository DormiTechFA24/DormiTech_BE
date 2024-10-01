using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class GenEmployeePosition
{
    public int PositionId { get; set; }

    public string? PositionName { get; set; }

    public virtual ICollection<GenEmployee> GenEmployees { get; set; } = new List<GenEmployee>();
}
