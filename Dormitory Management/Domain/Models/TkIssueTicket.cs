using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class TkIssueTicket
{
    public Guid TicketId { get; set; }

    public int? TicketTypeId { get; set; }

    public string? Header { get; set; }

    public string? Content { get; set; }

    public string? CommentThread { get; set; }

    public int? TicketStatusId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? ApprovedOn { get; set; }

    public Guid? ApprovedBy { get; set; }

    public int? RoomId { get; set; }

    public virtual ICollection<AccDisciplineTicket> AccDisciplineTickets { get; set; } = new List<AccDisciplineTicket>();

    public virtual SysAccount? ApprovedByNavigation { get; set; }

    public virtual SysAccount? CreatedByNavigation { get; set; }

    public virtual FacRoom? Room { get; set; }

    public virtual TkIssueTicketStatus? TicketStatus { get; set; }

    public virtual TkIssueTicketType? TicketType { get; set; }

    public virtual ICollection<TkIssueTicketDetail> TkIssueTicketDetails { get; set; } = new List<TkIssueTicketDetail>();

    public virtual ICollection<TkIssueTicketPhoto> TkIssueTicketPhotos { get; set; } = new List<TkIssueTicketPhoto>();

    public virtual ICollection<GenStudent> Students { get; set; } = new List<GenStudent>();
}
