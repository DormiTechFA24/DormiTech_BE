﻿namespace Domain.Model;

public partial class FacRoom
{
    public int RoomId { get; set; }

    public int? RoomTypeId { get; set; }

    public int? RoomStatus { get; set; }

    public int? BuildingId { get; set; }

    public int? Floor { get; set; }

    public virtual ICollection<AccRoomMonthly> AccRoomMonthlies { get; set; } = new List<AccRoomMonthly>();

    public virtual ICollection<AccRoomRealTime> AccRoomRealTimes { get; set; } = new List<AccRoomRealTime>();

    public virtual FacBuilding? Building { get; set; }

    public virtual FacRoomItem? FacRoomItem { get; set; }

    public virtual GenRoomStatus? RoomStatusNavigation { get; set; }

    public virtual GenRoomType? RoomType { get; set; }

    public virtual ICollection<TkIssueTicket> TkIssueTickets { get; set; } = new List<TkIssueTicket>();
}