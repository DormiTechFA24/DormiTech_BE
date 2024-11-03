using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.View_Models.ResponseModels
{
    public class EmployeeReponse
    {

        public string? EmployeeName { get; set; }

        public string? FullName { get; set; }

        public string? PhoneNumber { get; set; }

        public int? PositionId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }
    }
}
