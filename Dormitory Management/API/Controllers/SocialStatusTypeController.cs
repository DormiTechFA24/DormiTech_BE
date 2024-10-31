using Application.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SocialStatusTypeController : ControllerBase
    {
        private readonly ISocialStatusTypeService _socialStatusTypeService;

        public SocialStatusTypeController(ISocialStatusTypeService socialStatusTypeService)
        {
            _socialStatusTypeService = socialStatusTypeService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _socialStatusTypeService.GetAll();
            return Ok(result);
        }

        [HttpGet()]
        [Route("GetSocialStatusTypeById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _socialStatusTypeService.GetSocialStatusTypeById(id);
            return Ok(result);
        }
    }

}
