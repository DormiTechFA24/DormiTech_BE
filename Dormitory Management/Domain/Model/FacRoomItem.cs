namespace Domain.Model;

public partial class FacRoomItem
{
    public int RoomId { get; set; }

    public int? ItemId { get; set; }

    public int? Amount { get; set; }

    public virtual FacItem? Item { get; set; }

    public virtual FacRoom Room { get; set; } = null!;
}