using Microsoft.AspNetCore.Mvc;

namespace Application.Services.IServices
{
    public interface IAccountServices
    {
        Task<IActionResult> GetAll();
        Task<IActionResult> GetAccountId(int id);
    }
}