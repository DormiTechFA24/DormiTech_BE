using Application.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentService _documentService;
        public DocumentController(IDocumentService documentServices)
        {
            _documentService = documentServices;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var resul = await _documentService.GetAll();
            return Ok(resul);
        }

        [HttpGet()]
        [Route("Get Document ID")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var resul = await _documentService.GetDocumentId(id);
            return Ok(resul);
        }
    }
}
