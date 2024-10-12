namespace Domain.Model;

public partial class GenRoomStatus
{
    public int RoomStatusId { get; set; }

    public string? StatusName { get; set; }

    public virtual ICollection<FacRoom> FacRooms { get; set; } = new List<FacRoom>();
}