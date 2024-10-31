using Application.Services.IServices;
using Application.View_Models.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IssueTicketPhotoController : ControllerBase
    {
        private readonly IIssueTicketPhotoService _issueTicketPhotoService;

        public IssueTicketPhotoController(IIssueTicketPhotoService issueTicketPhotoService)
        {
            _issueTicketPhotoService = issueTicketPhotoService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _issueTicketPhotoService.GetAll();
            return Ok(result);
        }

        [HttpGet()]
        [Route("GetByTicketId")]
        public async Task<IActionResult> GetByTicketId(Guid id)
        {
            var result = await _issueTicketPhotoService.GetByTicketId(id);
            return Ok(result);
        }

        [HttpPost()]
        [Route("Create")]
        public async Task<IActionResult> Create(IssueTicketPhotoRequest request)
        {
            await _issueTicketPhotoService.Create(request);
            return Ok();
        }

        [HttpDelete()]
        [Route("Remove")]
        public async Task<IActionResult> Remove(IssueTicketPhotoRequest request)
        {
            await _issueTicketPhotoService.Delete(request);
            return Ok();
        }
    }
}
