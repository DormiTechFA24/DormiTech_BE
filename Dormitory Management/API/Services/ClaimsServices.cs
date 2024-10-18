using System.Security.Claims;
using Application.Services.IServices;

namespace WebAPI.Services
{
    public class ClaimsServices : IClaimsServices
    {
        private readonly IHttpContextAccessor _contextAccessor;

        //Truy cập thông tin current user => get id account
        public ClaimsServices(IHttpContextAccessor httpContextAccessor)
        {
            if (httpContextAccessor.HttpContext != null)
            {
                var id = httpContextAccessor.HttpContext.User.FindFirstValue("Id");
                GetCurrentUserId = id == null ? 8 : int.Parse(id);
            }
        }

        public int GetCurrentUserId { get; }
    }
}