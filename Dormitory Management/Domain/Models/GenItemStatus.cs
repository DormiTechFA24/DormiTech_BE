using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class GenItemStatus
{
    public int ItemStatusId { get; set; }

    public string? StatusName { get; set; }

    public virtual ICollection<TkIssueTicketDetail> TkIssueTicketDetails { get; set; } = new List<TkIssueTicketDetail>();
}
