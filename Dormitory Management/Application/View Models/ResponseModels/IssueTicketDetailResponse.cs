using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.View_Models.ResponseModels
{
    public class IssueTicketDetailResponse
    {
        public Guid TicketId { get; set; }

        public int OrderIndex { get; set; }

        public int? ItemId { get; set; }

        public int? ItemAmount { get; set; }

        public int? ItemStatusId { get; set; }
    }
}
