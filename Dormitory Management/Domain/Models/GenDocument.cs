﻿using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class GenDocument
{
    public int DocumentId { get; set; }

    public string? DocumentName { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public virtual ICollection<AccRoomApplicationDocument> AccRoomApplicationDocuments { get; set; } = new List<AccRoomApplicationDocument>();

    public virtual ICollection<SysDocumentSetUp> SysDocumentSetUps { get; set; } = new List<SysDocumentSetUp>();
}