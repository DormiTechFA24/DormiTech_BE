using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface IClaimsServices
    {
        //Lấy id User hiện tại
        public int GetCurrentUserId { get; }
    }
}
