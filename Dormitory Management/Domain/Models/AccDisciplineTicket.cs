using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class AccDisciplineTicket
{
    public Guid DisciplineTicketId { get; set; }

    public Guid? TicketId { get; set; }

    public Guid? StudentId { get; set; }

    public decimal? PaymentAmount { get; set; }

    public Guid? BillingId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public virtual ICollection<AccDisciplineTicketDocument> AccDisciplineTicketDocuments { get; set; } = new List<AccDisciplineTicketDocument>();

    public virtual BilBilling? Billing { get; set; }

    public virtual SysAccount? Student { get; set; }

    public virtual TkIssueTicket? Ticket { get; set; }

    public virtual ICollection<GenPunishmentType> PunishmentTypes { get; set; } = new List<GenPunishmentType>();
}
