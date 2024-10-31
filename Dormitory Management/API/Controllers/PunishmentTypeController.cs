using Application.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PunishmentTypeController : ControllerBase
    {
        private readonly IPunishmentTypeService _punishmentTypeService;

        public PunishmentTypeController(IPunishmentTypeService punishmentTypeService)
        {
            _punishmentTypeService = punishmentTypeService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _punishmentTypeService.GetAll();
            return Ok(result);
        }

        [HttpGet()]
        [Route("GetPunishmentTypeById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _punishmentTypeService.GetPunishmentTypeById(id);
            return Ok(result);
        }
    }

}
