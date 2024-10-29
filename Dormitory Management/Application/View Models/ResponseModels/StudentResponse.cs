using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.View_Models.ResponseModels
{
    public class StudentResponse
    {
        public Guid StudentId { get; set; }

        public string? StudentName { get; set; }

        public string? FullName { get; set; }

        public DateTime? DoB { get; set; }

        public DateTime? EnrolledOn { get; set; }

        public int? Gender { get; set; }

        public int? DistanceTypeId { get; set; }

        public string? MajorName { get; set; }

        public int? Ethnicity { get; set; }

        public string? Address { get; set; }

        public int? ProvinceId { get; set; }

        public int? DistrictId { get; set; }

        public int? WardId { get; set; }

        public int? SocialTypeId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }
    }
}
