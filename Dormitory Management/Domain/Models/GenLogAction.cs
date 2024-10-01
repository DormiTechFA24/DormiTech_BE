using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class GenLogAction
{
    public int? ActionId { get; set; }

    public int? ActionType { get; set; }

    public string? TypeName { get; set; }
}
