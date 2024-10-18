using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ResponseModels
{
    public class RoomResponse
    {
        public int? RoomTypeId { get; set; }

        public int? RoomStatus { get; set; }

        public int? BuildingId { get; set; }

        public int? Floor { get; set; }
    }
}
