﻿using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class AccDisciplineTicketPunishment
{
    public Guid? TicketId { get; set; }

    public int? PunishmentTypeId { get; set; }
}