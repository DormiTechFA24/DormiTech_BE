using Application.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class RoomController : ControllerBase
    {
        private readonly IRoomServices _roomServices;
        public RoomController(IRoomServices roomServices)
        {
            _roomServices = roomServices;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var resul = await _roomServices.GetAll();
            return Ok(resul);
        }
        [HttpGet()]
        [Route("Get Room ID")]
        public async Task<IActionResult> GetById(int id)
        {
            var resul = await _roomServices.GetRoomById(id);
            return Ok(resul);
        }
    }
}
