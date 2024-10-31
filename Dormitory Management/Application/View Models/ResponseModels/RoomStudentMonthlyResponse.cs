using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.View_Models.ResponseModels
{
    public class RoomStudentMonthlyResponse
    {
        public Guid StudentId { get; set; }

        public Guid AccRoomId { get; set; }

        public Guid? BillingId { get; set; }

        public virtual AccRoomMonthly AccRoom { get; set; } = null!;

        public virtual BilBilling? Billing { get; set; }

        public virtual SysAccount Student { get; set; } = null!;
    }
}
