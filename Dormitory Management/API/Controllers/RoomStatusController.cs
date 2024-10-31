using Application.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomStatusController : ControllerBase
    {
        private readonly IRoomStatusService _roomStatusService;

        public RoomStatusController(IRoomStatusService roomStatusService)
        {
            _roomStatusService = roomStatusService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _roomStatusService.GetAll();
            return Ok(result);
        }

        [HttpGet()]
        [Route("GetRoomStatusById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _roomStatusService.GetRoomStatusById(id);
            return Ok(result);
        }
    }

}
