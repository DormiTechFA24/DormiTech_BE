using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class GenAmenity
{
    public int AmenityId { get; set; }

    public string? AmenityName { get; set; }

    public virtual ICollection<GenRoomType> RoomTypes { get; set; } = new List<GenRoomType>();
}
