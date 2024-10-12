namespace Domain.Model;

public partial class TkIssueTicketType
{
    public int TicketTypeId { get; set; }

    public string? TypeName { get; set; }

    public virtual ICollection<TkIssueTicket> TkIssueTickets { get; set; } = new List<TkIssueTicket>();
}