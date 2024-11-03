using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ResponseModels
{
    public class RoomResponse
    {
        public string? RoomTypeId { get; set; }

        public string? RoomStatus { get; set; }

        public string? BuildingId { get; set; }

        public int? Floor { get; set; }
    }
}
