using Application.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _serviceService.GetAll();
            return Ok(result);
        }

        [HttpGet()]
        [Route("GetServiceById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _serviceService.GetServiceById(id);
            return Ok(result);
        }
    }

}
