namespace Domain.Model;

public partial class GenStudent
{
    public Guid StudentId { get; set; }

    public string? StudentName { get; set; }

    public string? FullName { get; set; }

    public DateTime? DoB { get; set; }

    public DateTime? EnrolledOn { get; set; }

    public int? Gender { get; set; }

    public int? DistanceTypeId { get; set; }

    public string? MajorName { get; set; }

    public int? Ethnicity { get; set; }

    public string? Address { get; set; }

    public int? ProvinceId { get; set; }

    public int? DistrictId { get; set; }

    public int? WardId { get; set; }

    public int? SocialTypeId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public virtual GenDistanceType? DistanceType { get; set; }

    public virtual GenDistrict? District { get; set; }

    public virtual GenEthnicity? EthnicityNavigation { get; set; }

    public virtual GenProvince? Province { get; set; }

    public virtual GenSocialStatusType? SocialType { get; set; }

    public virtual GenWard? Ward { get; set; }

    public virtual ICollection<TkIssueTicket> Tickets { get; set; } = new List<TkIssueTicket>();
}