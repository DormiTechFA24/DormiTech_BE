namespace Domain.Model;

public partial class LogRoomApplication
{
    public int? HistorySeq { get; set; }

    public Guid? RequestId { get; set; }

    public string? LogNote { get; set; }

    public int? ApproveStatus { get; set; }

    public DateTime? StatusChangedOn { get; set; }

    public Guid? StatusChangedBy { get; set; }

    public virtual AccRoomRequest? Request { get; set; }
}