using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.View_Models.ResponseModels
{
    public class SocialStatusTypeResponse
    {
        public int SocialTypeId { get; set; }

        public string? TypeName { get; set; }

        public int? PrimaryPaytypeId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }
    }
}