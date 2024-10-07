using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class GenEthnicity
{
    public int EthnicityId { get; set; }

    public string? EthnicityName { get; set; }

    public virtual ICollection<GenStudent> GenStudents { get; set; } = new List<GenStudent>();
}
