using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class AccRoomApplicationDocument
{
    public Guid ApplicationId { get; set; }

    public int OrderIndex { get; set; }

    public int? DocumentTypeId { get; set; }

    public string? FileLink { get; set; }

    public int? ApproveStatus { get; set; }

    public DateTime? StatusChangedOn { get; set; }

    public Guid? StatusChangedBy { get; set; }

    public virtual AccRoomApplication Application { get; set; } = null!;

    public virtual GenDocument? DocumentType { get; set; }
}
