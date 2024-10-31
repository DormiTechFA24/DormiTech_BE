using Application.Services.IServices;
using Application.View_Models.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomRequestController : ControllerBase
    {
        private readonly IRoomRequestService _roomRequestService;

        public RoomRequestController(IRoomRequestService roomRequestService)
        {
            _roomRequestService = roomRequestService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _roomRequestService.GetAll();
            return Ok(result);
        }

        [HttpGet()]
        [Route("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _roomRequestService.GetById(id);
            return Ok(result);
        }

        [HttpGet()]
        [Route("GetByStudentId")]
        public async Task<IActionResult> GetByStudentId(Guid id)
        {
            var result = await _roomRequestService.GetByStudentId(id);
            return Ok(result);
        }

        [HttpGet()]
        [Route("GetFromDateToDate")]
        public async Task<IActionResult> GetFromDateToDate(DateTime from, DateTime to)
        {
            var result = await _roomRequestService.GetFromDateToDate(from, to);
            return Ok(result);
        }

        [HttpPost()]
        [Route("Create")]
        public async Task<IActionResult> Create(RoomReqRequest request)
        {
            await _roomRequestService.Create(request);
            return Ok();
        }

        [HttpDelete()]
        [Route("Remove")]
        public async Task<IActionResult> Remove(RoomReqRequest request)
        {
            await _roomRequestService.Delete(request);
            return Ok();
        }
    }
}
