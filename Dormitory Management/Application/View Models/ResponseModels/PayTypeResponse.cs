using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.View_Models.ResponseModels
{
    public class PayTypeResponse
    {
        public int PayTypeId { get; set; }

        public string? TypeName { get; set; }

        public int? DiscountPercent { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }
    }
}
