using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class AccRoomRequest
{
    public Guid RequestId { get; set; }

    public string? StudentNote { get; set; }

    public string? EmployerNote { get; set; }

    public DateTime? AppliedOn { get; set; }

    public Guid? AppliedBy { get; set; }

    public int? ApproveStatus { get; set; }

    public DateTime? StatusChangedOn { get; set; }

    public Guid? StatusChangedBy { get; set; }

    public int? RoomTypeId { get; set; }

    public virtual ICollection<AccRoomApplicationDocument> AccRoomApplicationDocuments { get; set; } = new List<AccRoomApplicationDocument>();

    public virtual SysAccount? AppliedByNavigation { get; set; }

    public virtual GenRoomType? RoomType { get; set; }

    public virtual SysAccount? StatusChangedByNavigation { get; set; }
}
