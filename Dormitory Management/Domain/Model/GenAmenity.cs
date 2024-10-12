﻿namespace Domain.Model;

public partial class GenAmenity
{
    public int AmenityId { get; set; }

    public string? AmenityName { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public virtual ICollection<GenRoomType> RoomTypes { get; set; } = new List<GenRoomType>();
}