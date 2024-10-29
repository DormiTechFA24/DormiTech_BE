using Application.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EthnicityController : ControllerBase
    {
        private readonly IEthnicityService _ethnicityService;

        public EthnicityController(IEthnicityService ethnicityService)
        {
            _ethnicityService = ethnicityService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _ethnicityService.GetAll();
            return Ok(result);
        }

        [HttpGet()]
        [Route("GetEthnicityById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _ethnicityService.GetEthnicityById(id);
            return Ok(result);
        }
    }

}
