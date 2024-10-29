using Application.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WardController : ControllerBase
    {
        private readonly IWardService _wardService;

        public WardController(IWardService wardService)
        {
            _wardService = wardService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _wardService.GetAll();
            return Ok(result);
        }

        [HttpGet()]
        [Route("GetWardById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _wardService.GetWardById(id);
            return Ok(result);
        }
    }

}
