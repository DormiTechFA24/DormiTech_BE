using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.View_Models.RequestModels
{
    public class RoomReqRequest
    {
        public Guid RequestId { get; set; }

        public string? StudentNote { get; set; }

        public string? EmployerNote { get; set; }

        public DateTime? AppliedOn { get; set; }

        public Guid? AppliedBy { get; set; }

        public int? ApproveStatus { get; set; }

        public DateTime? StatusChangedOn { get; set; }

        public Guid? StatusChangedBy { get; set; }

        public int? RoomTypeId { get; set; }
    }
}
