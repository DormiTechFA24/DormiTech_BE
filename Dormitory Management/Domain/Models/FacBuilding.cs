using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class FacBuilding
{
    public int BuildingId { get; set; }

    public string? BuildingName { get; set; }

    public string? BuildingDescription { get; set; }

    public int? FloorNumber { get; set; }

    public virtual ICollection<FacRoom> FacRooms { get; set; } = new List<FacRoom>();
}
