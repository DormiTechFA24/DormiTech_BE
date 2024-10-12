namespace Domain.Model;

public partial class TkIssueTicketDetail
{
    public Guid TicketId { get; set; }

    public int OrderIndex { get; set; }

    public int? ItemId { get; set; }

    public int? ItemAmount { get; set; }

    public int? ItemStatusId { get; set; }

    public virtual FacItem? Item { get; set; }

    public virtual GenItemStatus? ItemStatus { get; set; }

    public virtual TkIssueTicket Ticket { get; set; } = null!;
}