using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class AccRoomRealTime
{
    public int RoomId { get; set; }

    public Guid StudentId { get; set; }

    public string? Note { get; set; }

    public virtual FacRoom Room { get; set; } = null!;

    public virtual SysAccount Student { get; set; } = null!;
}
