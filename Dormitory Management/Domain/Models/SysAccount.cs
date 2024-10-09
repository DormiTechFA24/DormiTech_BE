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

    public virtual ICollection<AccRoomRealTime> AccRoomRealTimes { get; set; } = new List<AccRoomRealTime>();

    public virtual ICollection<AccRoomRequest> AccRoomRequestAppliedByNavigations { get; set; } = new List<AccRoomRequest>();

    public virtual ICollection<AccRoomRequest> AccRoomRequestStatusChangedByNavigations { get; set; } = new List<AccRoomRequest>();

    public virtual ICollection<AccRoomStudentMonthly> AccRoomStudentMonthlies { get; set; } = new List<AccRoomStudentMonthly>();

    public virtual ICollection<BilBilling> BilBillingStudents { get; set; } = new List<BilBilling>();

    public virtual ICollection<BilBilling> BilBillingVerifiedByNavigations { get; set; } = new List<BilBilling>();

    public virtual ICollection<TkIssueTicket> TkIssueTicketApprovedByNavigations { get; set; } = new List<TkIssueTicket>();

    public virtual ICollection<TkIssueTicket> TkIssueTicketCreatedByNavigations { get; set; } = new List<TkIssueTicket>();

    public virtual ICollection<SysRole> Roles { get; set; } = new List<SysRole>();
}
