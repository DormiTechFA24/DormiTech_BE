namespace Domain.Model;

public partial class FacItem
{
    public int ItemId { get; set; }

    public string? ItemName { get; set; }

    public decimal? UnitPrice { get; set; }

    public virtual ICollection<FacRoomItem> FacRoomItems { get; set; } = new List<FacRoomItem>();

    public virtual ICollection<TkIssueTicketDetail> TkIssueTicketDetails { get; set; } =
        new List<TkIssueTicketDetail>();
}