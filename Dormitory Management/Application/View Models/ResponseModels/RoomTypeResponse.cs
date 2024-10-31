using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.View_Models.ResponseModels
{
    public class RoomTypeResponse
    {
        public int RoomTypeId { get; set; }

        public string? TypeName { get; set; }

        public decimal? PricePerStudent { get; set; }

        public int? Capacity { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }
    }
}
