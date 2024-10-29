using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.View_Models.ResponseModels
{
    public class ServicePricingResponse
    {
        public int ServiceId { get; set; }

        public int MaxRoomCapacity { get; set; }

        public decimal MaxUnitCount { get; set; }

        public decimal? UnitPrice { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }
    }
}
