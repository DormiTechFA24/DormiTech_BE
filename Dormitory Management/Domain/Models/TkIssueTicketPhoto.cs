using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class TkIssueTicketPhoto
{
    public Guid TicketId { get; set; }

    public int PhotoIndex { get; set; }

    public string? PhotoLink { get; set; }

    public virtual TkIssueTicket Ticket { get; set; } = null!;
}
