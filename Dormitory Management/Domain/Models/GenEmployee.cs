using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class GenEmployee
{
    public Guid EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public string? FullName { get; set; }

    public string? PhoneNumber { get; set; }

    public int? PositionId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public virtual GenEmployeePosition? Position { get; set; }
}
