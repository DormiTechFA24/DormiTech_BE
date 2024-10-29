using Application.Services.IServices;
using Application.View_Models.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IssueTicketDetailsController : ControllerBase
    {
        private readonly IIssueTicketDetailsService _issueTicketDetailsService;

        public IssueTicketDetailsController(IIssueTicketDetailsService issueTicketDetailsService)
        {
            _issueTicketDetailsService = issueTicketDetailsService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _issueTicketDetailsService.GetAll();
            return Ok(result);
        }

        [HttpGet()]
        [Route("GetByTicketId")]
        public async Task<IActionResult> GetByTicketId(Guid id)
        {
            var result = await _issueTicketDetailsService.GetByTicketId(id);
            return Ok(result);
        }

        [HttpPost()]
        [Route("Create")]
        public async Task<IActionResult> Create(IssueTicketDetailsRequest request)
        {
            await _issueTicketDetailsService.Create(request);
            return Ok();
        }

        [HttpDelete()]
        [Route("Remove")]
        public async Task<IActionResult> Remove(IssueTicketDetailsRequest request)
        {
            await _issueTicketDetailsService.Delete(request);
            return Ok();
        }
    }

}
