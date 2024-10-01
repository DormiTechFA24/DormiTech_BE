using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class TkIssueTicketStatus
{
    public int TicketStatusId { get; set; }

    public string? StatusName { get; set; }

    public virtual ICollection<TkIssueTicket> TkIssueTickets { get; set; } = new List<TkIssueTicket>();
}
