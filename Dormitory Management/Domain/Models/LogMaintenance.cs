using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class LogMaintenance
{
    public int? HistorySeq { get; set; }

    public int? RoomId { get; set; }

    public int? ItemId { get; set; }

    public int? Amount { get; set; }

    public int? ItemStatusId { get; set; }

    public int? ActionId { get; set; }

    public decimal? Cost { get; set; }

    public DateTime? LogAt { get; set; }

    public virtual FacItem? Item { get; set; }

    public virtual FacRoom? Room { get; set; }
}
