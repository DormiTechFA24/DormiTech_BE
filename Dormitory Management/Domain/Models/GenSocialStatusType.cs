﻿using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class GenSocialStatusType
{
    public int SocialTypeId { get; set; }

    public string? TypeName { get; set; }

    public int? PrimaryPaytypeId { get; set; }

    public virtual GenPayType? PrimaryPaytype { get; set; }
}