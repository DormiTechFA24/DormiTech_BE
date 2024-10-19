using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;

namespace Infrastructure.Repositories
{
    public class FacRoomAmentityRepository : GenericRepository<FacRoom>, IFacRoomAmenityRepository
    {
        public FacRoomAmentityRepository(DormiTechContext context, IClaimsServices claimsService) : base(context, claimsService)
        {
        }
    }
}
