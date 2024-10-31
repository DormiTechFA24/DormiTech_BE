using Application.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PayTypeController : ControllerBase
    {
        private readonly IPayTypeService _payTypeService;

        public PayTypeController(IPayTypeService payTypeService)
        {
            _payTypeService = payTypeService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _payTypeService.GetAll();
            return Ok(result);
        }

        [HttpGet()]
        [Route("GetPayTypeById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _payTypeService.GetPayTypeById(id);
            return Ok(result);
        }
    }

}
