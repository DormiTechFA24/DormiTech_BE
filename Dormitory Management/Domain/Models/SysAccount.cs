using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class SysAccount
{
    public Guid AccountId { get; set; }

    public bool? IsStudent { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public DateTime? CreatedOn { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<AccDisciplineTicket> AccDisciplineTickets { get; set; } = new List<AccDisciplineTicket>();

    public virtual ICollection<AccRoomApplication> AccRoomApplicationAppliedByNavigations { get; set; } = new List<AccRoomApplication>();

    public virtual ICollection<AccRoomApplication> AccRoomApplicationStatusChangedByNavigations { get; set; } = new List<AccRoomApplication>();

    public virtual ICollection<AccRoomMonthly> AccRoomMonthlies { get; set; } = new List<AccRoomMonthly>();

    public virtual ICollection<AccRoomRealTime> AccRoomRealTimes { get; set; } = new List<AccRoomRealTime>();

    public virtual GenEmployee Account { get; set; } = null!;

    public virtual ICollection<BilBilling> BilBillingStudents { get; set; } = new List<BilBilling>();

    public virtual ICollection<BilBilling> BilBillingVerifiedByNavigations { get; set; } = new List<BilBilling>();

    public virtual GenStudent? GenStudent { get; set; }

    public virtual ICollection<TkIssueTicket> TkIssueTicketApprovedByNavigations { get; set; } = new List<TkIssueTicket>();

    public virtual ICollection<TkIssueTicket> TkIssueTicketCreatedByNavigations { get; set; } = new List<TkIssueTicket>();

    public virtual ICollection<SysRole> Roles { get; set; } = new List<SysRole>();
}
