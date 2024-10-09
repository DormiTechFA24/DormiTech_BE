using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class GenWard
{
    public int WardId { get; set; }

    public string? WardName { get; set; }

    public virtual ICollection<GenStudent> GenStudents { get; set; } = new List<GenStudent>();
}
