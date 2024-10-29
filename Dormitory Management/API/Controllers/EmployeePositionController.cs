using Application.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeePositionController : ControllerBase
    {
        private readonly IEmployeePositionService _employeePositionService;

        public EmployeePositionController(IEmployeePositionService employeePositionService)
        {
            _employeePositionService = employeePositionService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _employeePositionService.GetAll();
            return Ok(result);
        }

        [HttpGet()]
        [Route("GetEmployeePositionById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _employeePositionService.GetEmployeePositionById(id);
            return Ok(result);
        }
    }

}
