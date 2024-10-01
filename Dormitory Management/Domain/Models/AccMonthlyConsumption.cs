using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class AccMonthlyConsumption
{
    public int RoomId { get; set; }

    public decimal? ElectricityUnitPrice { get; set; }

    public decimal? WaterUnitPrice { get; set; }

    public decimal? ElectricityAmount { get; set; }

    public decimal? WaterAmount { get; set; }

    public decimal? ServiceFee { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }

    public DateTime? CreatedOn { get; set; }

    public virtual FacRoom Room { get; set; } = null!;
}
