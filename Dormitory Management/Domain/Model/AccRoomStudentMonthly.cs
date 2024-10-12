namespace Domain.Model;

public partial class AccRoomStudentMonthly
{
    public Guid StudentId { get; set; }

    public Guid AccRoomId { get; set; }

    public Guid? BillingId { get; set; }

    public virtual AccRoomMonthly AccRoom { get; set; } = null!;

    public virtual BilBilling? Billing { get; set; }

    public virtual SysAccount Student { get; set; } = null!;
}