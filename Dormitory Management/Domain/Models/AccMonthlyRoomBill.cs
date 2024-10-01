using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class AccMonthlyRoomBill
{
    public int RoomId { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }

    public decimal? PricePerStudent { get; set; }

    public DateTime? CreatedOn { get; set; }

    public virtual FacRoom Room { get; set; } = null!;
}
