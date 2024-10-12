﻿namespace Domain.Model;

public partial class GenBillType
{
    public int BillTypeId { get; set; }

    public string? TypeName { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public virtual ICollection<BilBilling> BilBillings { get; set; } = new List<BilBilling>();
}