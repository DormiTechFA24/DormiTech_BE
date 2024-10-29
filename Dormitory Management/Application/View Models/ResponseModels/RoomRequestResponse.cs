using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.View_Models.ResponseModels
{
    public class RoomRequestResponse
    {
        public int? RoomTypeId { get; set; }

        public int? RoomStatus { get; set; }

        public int? BuildingId { get; set; }

        public int? Floor { get; set; }
    }
}
