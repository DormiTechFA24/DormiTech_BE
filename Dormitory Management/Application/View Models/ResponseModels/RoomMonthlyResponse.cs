using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.View_Models.ResponseModels
{
    public class RoomMonthlyResponse
    {
        public int RoomId { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public Guid? AccRoomId { get; set; }

        public decimal? PricePerStudent { get; set; }

        public decimal? ElectricityUnitPrice { get; set; }

        public decimal? WaterUnitPrice { get; set; }

        public decimal? ElectricityAmount { get; set; }

        public decimal? WaterAmount { get; set; }

        public decimal? ServiceFee { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string? Note { get; set; }
    }
}
