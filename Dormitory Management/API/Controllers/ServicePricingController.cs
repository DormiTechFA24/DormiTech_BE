using Application.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServicePricingController : ControllerBase
    {
        private readonly IServicePricingService _servicePricingService;

        public ServicePricingController(IServicePricingService servicePricingService)
        {
            _servicePricingService = servicePricingService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _servicePricingService.GetAll();
            return Ok(result);
        }

        [HttpGet()]
        [Route("GetServicePricingById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _servicePricingService.GetServicePricingById(id);
            return Ok(result);
        }
    }

}
