using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.View_Models.ResponseModels
{
    public class PunishmentTypeResponse
    {
        public int PunishmentTypeId { get; set; }

        public string? PunishmentName { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }
    }
}
