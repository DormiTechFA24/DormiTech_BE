using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class BilBilling
{
    public Guid BillingId { get; set; }

    public Guid? StudentId { get; set; }

    public int? Amount { get; set; }

    public bool? IsPaid { get; set; }

    public string? Note { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? PaymentDeadline { get; set; }

    public DateTime? PaidOn { get; set; }

    public Guid? VerifiedBy { get; set; }

    public Guid? TicketId { get; set; }

    public int? RoomId { get; set; }

    public int? Month { get; set; }

    public int? Year { get; set; }

    public int? BillTypeId { get; set; }

    public int? PayTypeId { get; set; }

    public virtual GenBillType? BillType { get; set; }

    public virtual FacRoom? Room { get; set; }

    public virtual SysAccount? Student { get; set; }

    public virtual SysAccount? VerifiedByNavigation { get; set; }
}
