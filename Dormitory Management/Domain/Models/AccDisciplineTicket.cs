using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class AccDisciplineTicket
{
    public Guid TicketId { get; set; }

    public Guid StudentId { get; set; }

    public decimal? PaymentAmount { get; set; }

    public virtual SysAccount Student { get; set; } = null!;

    public virtual TkIssueTicket Ticket { get; set; } = null!;
}
