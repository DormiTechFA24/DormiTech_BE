using Application.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProvinceController : ControllerBase
    {
        private readonly IProvinceService _provinceService;

        public ProvinceController(IProvinceService provinceService)
        {
            _provinceService = provinceService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _provinceService.GetAll();
            return Ok(result);
        }

        [HttpGet()]
        [Route("GetProvinceById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _provinceService.GetProvinceById(id);
            return Ok(result);
        }
    }

}
