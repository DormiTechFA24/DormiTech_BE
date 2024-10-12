namespace Domain.Model;

public partial class GenService
{
    public int ServiceId { get; set; }

    public string? ServiceName { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public virtual ICollection<GenServicePricing> GenServicePricings { get; set; } = new List<GenServicePricing>();
}