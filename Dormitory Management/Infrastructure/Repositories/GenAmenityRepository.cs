using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;

namespace Infrastructure.Repositories
{
    public class GenAmenityRepository : GenericRepository<GenAmenity>, IGenAmenityRepository
    {
        public GenAmenityRepository(DormiTechContext context, IClaimsServices claimsService) : base(context, claimsService)
        {
        }
    }
}
