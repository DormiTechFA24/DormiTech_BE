using Application.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IssueTicketStatusController : ControllerBase
    {
        private readonly IIssueTicketStatusService _issueTicketStatusService;

        public IssueTicketStatusController(IIssueTicketStatusService issueTicketStatusService)
        {
            _issueTicketStatusService = issueTicketStatusService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _issueTicketStatusService.GetAll();
            return Ok(result);
        }

        [HttpGet()]
        [Route("GetIssueTicketStatusById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _issueTicketStatusService.GetIssueTicketStatusById(id);
            return Ok(result);
        }
    }
}
