using Application.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IssueTicketTypeController : ControllerBase
    {
        private readonly IIssueTicketTypeService _issueTicketTypeService;

        public IssueTicketTypeController(IIssueTicketTypeService issueTicketTypeService)
        {
            _issueTicketTypeService = issueTicketTypeService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _issueTicketTypeService.GetAll();
            return Ok(result);
        }

        [HttpGet()]
        [Route("GetIssueTicketTypeById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _issueTicketTypeService.GetIssueTicketTypeById(id);
            return Ok(result);
        }
    }

}
