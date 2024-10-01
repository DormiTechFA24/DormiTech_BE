using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class GenWaterPricing
{
    public int? MaxRoomCapacity { get; set; }

    public decimal? MaxUnitCount { get; set; }

    public decimal? UnitPrice { get; set; }
}
