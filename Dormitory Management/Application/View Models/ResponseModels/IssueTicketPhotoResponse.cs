﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.View_Models.ResponseModels
{
    public class IssueTicketPhotoResponse
    {
        public Guid TicketId { get; set; }

        public int PhotoIndex { get; set; }

        public string? PhotoLink { get; set; }
    }
}