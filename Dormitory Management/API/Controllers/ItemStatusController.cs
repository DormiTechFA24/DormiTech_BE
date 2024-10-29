using Application.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemStatusController : ControllerBase
    {
        private readonly IItemStatusService _itemStatusService;

        public ItemStatusController(IItemStatusService itemStatusService)
        {
            _itemStatusService = itemStatusService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _itemStatusService.GetAll();
            return Ok(result);
        }

        [HttpGet()]
        [Route("GetItemStatusById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _itemStatusService.GetItemStatusById(id);
            return Ok(result);
        }
    }


}
