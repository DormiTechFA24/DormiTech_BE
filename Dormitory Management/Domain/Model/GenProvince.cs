namespace Domain.Model;

public partial class GenProvince
{
    public int ProvinceId { get; set; }

    public string? ProvinceName { get; set; }

    public virtual ICollection<GenStudent> GenStudents { get; set; } = new List<GenStudent>();
}