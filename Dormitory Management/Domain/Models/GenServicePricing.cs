using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class GenServicePricing
{
    public int ServiceId { get; set; }

    public int MaxRoomCapacity { get; set; }

    public decimal MaxUnitCount { get; set; }

    public decimal? UnitPrice { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public virtual GenService Service { get; set; } = null!;
}
