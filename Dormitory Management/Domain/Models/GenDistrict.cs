using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class GenDistrict
{
    public int DistrictId { get; set; }

    public string? DistrictName { get; set; }

    public virtual ICollection<GenStudent> GenStudents { get; set; } = new List<GenStudent>();
}
