using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class GenStudent
{
    public Guid StudentId { get; set; }

    public string? StudentCode { get; set; }

    public string? FullName { get; set; }

    public DateOnly? DoB { get; set; }

    public DateOnly? EnrolledOn { get; set; }

    public int? Gender { get; set; }

    public int? Ethnicity { get; set; }

    public int? SocialTypeId { get; set; }

    public int? DistanceTypeId { get; set; }

    public int? MajorId { get; set; }

    public virtual GenEthnicity? EthnicityNavigation { get; set; }

    public virtual GenSocialStatusType? SocialType { get; set; }

    public virtual SysAccount Student { get; set; } = null!;

    public virtual ICollection<TkIssueTicket> Tickets { get; set; } = new List<TkIssueTicket>();
}
