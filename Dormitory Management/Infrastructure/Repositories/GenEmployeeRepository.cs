using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;
namespace Infrastructure.Repositories
{
    public class GenEmployeeRepository : GenericRepository<GenEmployee>, IGenEmployeeRepository
    {
        public GenEmployeeRepository(DormiTechContext context, IClaimsServices claimsService) : base(context, claimsService)
        {
        }
    }
}
