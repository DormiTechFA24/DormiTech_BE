using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class GenBillType
{
    public int BillTypeId { get; set; }

    public string? TypeName { get; set; }

    public virtual ICollection<BilBilling> BilBillings { get; set; } = new List<BilBilling>();
}
