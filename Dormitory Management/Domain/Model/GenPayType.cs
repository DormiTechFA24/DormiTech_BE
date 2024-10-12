namespace Domain.Model;

public partial class GenPayType
{
    public int PayTypeId { get; set; }

    public string? TypeName { get; set; }

    public int? DiscountPercent { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public virtual ICollection<BilBilling> BilBillings { get; set; } = new List<BilBilling>();

    public virtual ICollection<GenSocialStatusType> GenSocialStatusTypes { get; set; } =
        new List<GenSocialStatusType>();
}