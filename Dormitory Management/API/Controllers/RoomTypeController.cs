using Application.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomTypeController : ControllerBase
    {
        private readonly IRoomTypeService _roomTypeService;

        public RoomTypeController(IRoomTypeService roomTypeService)
        {
            _roomTypeService = roomTypeService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _roomTypeService.GetAll();
            return Ok(result);
        }

        [HttpGet()]
        [Route("GetRoomTypeById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _roomTypeService.GetRoomTypeById(id);
            return Ok(result);
        }
    }

}
