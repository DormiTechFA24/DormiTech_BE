using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.View_Models.ResponseModels
{
    public class DisciplineResponse
    {

        public Guid? TicketId { get; set; }

        public Guid? StudentId { get; set; }

        public decimal? PaymentAmount { get; set; }

        public Guid? BillingId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }
    }
}
