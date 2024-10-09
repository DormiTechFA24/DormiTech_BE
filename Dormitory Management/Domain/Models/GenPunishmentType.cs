using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class GenPunishmentType
{
    public int PunishmentTypeId { get; set; }

    public string? PunishmentName { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public virtual ICollection<AccDisciplineTicket> Tickets { get; set; } = new List<AccDisciplineTicket>();
}
