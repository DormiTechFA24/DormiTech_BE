using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class GenRoomType
{
    public int RoomTypeId { get; set; }

    public string? TypeName { get; set; }

    public decimal? PricePerStudent { get; set; }

    public int? Capacity { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public virtual ICollection<AccRoomRequest> AccRoomRequests { get; set; } = new List<AccRoomRequest>();

    public virtual ICollection<FacRoom> FacRooms { get; set; } = new List<FacRoom>();

    public virtual ICollection<GenAmenity> Amenities { get; set; } = new List<GenAmenity>();
}
