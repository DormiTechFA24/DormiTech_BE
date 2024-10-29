using Application.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ModuleTypeController : ControllerBase
    {
        private readonly IModuleTypeService _moduleTypeService;

        public ModuleTypeController(IModuleTypeService moduleTypeService)
        {
            _moduleTypeService = moduleTypeService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _moduleTypeService.GetAll();
            return Ok(result);
        }

        [HttpGet()]
        [Route("GetModuleTypeById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _moduleTypeService.GetModuleTypeById(id);
            return Ok(result);
        }
    }

}
