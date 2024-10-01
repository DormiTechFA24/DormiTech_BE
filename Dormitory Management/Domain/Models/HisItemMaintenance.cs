using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class HisItemMaintenance
{
    public int? ItemId { get; set; }

    public int? ItemStatusBefore { get; set; }

    public int? ItemStatusAfter { get; set; }

    public decimal? MaintenanceFee { get; set; }

    public int? ItemAmount { get; set; }

    public DateTime? ReportedAt { get; set; }

    public Guid? ReportedBy { get; set; }

    public DateTime? ResolvedAt { get; set; }

    public Guid? ResolvedBy { get; set; }

    public Guid? TicketId { get; set; }

    public virtual FacItem? Item { get; set; }

    public virtual GenItemStatus? ItemStatusAfterNavigation { get; set; }

    public virtual GenItemStatus? ItemStatusBeforeNavigation { get; set; }

    public virtual SysAccount? ReportedByNavigation { get; set; }

    public virtual SysAccount? ResolvedByNavigation { get; set; }

    public virtual TkIssueTicket? Ticket { get; set; }
}
