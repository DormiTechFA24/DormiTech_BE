using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class GenPayType
{
    public int PayTypeId { get; set; }

    public string? TypeName { get; set; }

    public int? DiscountPercent { get; set; }

    public virtual ICollection<GenSocialStatusType> GenSocialStatusTypes { get; set; } = new List<GenSocialStatusType>();
}
