namespace Domain.Model;

public partial class GenDistanceType
{
    public int DistanceTypeId { get; set; }

    public string? TypeName { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public virtual ICollection<GenStudent> GenStudents { get; set; } = new List<GenStudent>();
}