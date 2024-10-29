using Application.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomStudentMonthlyController : ControllerBase
    {
        private readonly IRoomStudentMonthlyService _roomStudentMonthlyService;

        public RoomStudentMonthlyController(IRoomStudentMonthlyService roomStudentMonthlyService)
        {
            _roomStudentMonthlyService = roomStudentMonthlyService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _roomStudentMonthlyService.GetAll();
            return Ok(result);
        }

        [HttpGet()]
        [Route("GetByStudentId")]
        public async Task<IActionResult> GetByStudentId(Guid id)
        {
            var result = await _roomStudentMonthlyService.GetByStudentId(id);
            return Ok(result);
        }
    }
}
