using Application.Services.IServices;
using Application.View_Models.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomMonthlyController : ControllerBase
    {
        private readonly IRoomMonthlyService _roomMonthlyService;

        public RoomMonthlyController(IRoomMonthlyService roomMonthlyService)
        {
            _roomMonthlyService = roomMonthlyService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _roomMonthlyService.GetAll();
            return Ok(result);
        }

        [HttpGet()]
        [Route("GetByRoomId")]
        public async Task<IActionResult> GetByRoomId(Guid id)
        {
            var result = await _roomMonthlyService.GetByRoomId(id);
            return Ok(result);
        }

        [HttpGet()]
        [Route("GetFromDateToDate")]
        public async Task<IActionResult> GetFromDateToDate(DateTime from, DateTime to)
        {
            var result = await _roomMonthlyService.GetFromDateToDate(from, to);
            return Ok(result);
        }
    }
}
