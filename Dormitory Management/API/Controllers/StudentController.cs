using Application.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _studentService.GetAll();
            return Ok(result);
        }

        [HttpGet()]
        [Route("GetStudentById")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _studentService.GetStudentById(id);
            return Ok(result);
        }
    }

}
