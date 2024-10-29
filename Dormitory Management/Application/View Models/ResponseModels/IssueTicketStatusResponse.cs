using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.View_Models.ResponseModels
{
    public class IssueTicketStatusResponse
    {
        public int TicketStatusId { get; set; }

        public string? StatusName { get; set; }
    }
}
