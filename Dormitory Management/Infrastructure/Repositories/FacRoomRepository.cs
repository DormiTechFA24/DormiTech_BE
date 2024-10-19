using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;

namespace Infrastructure.Repositories;

public sealed class FacRoomRepository : GenericRepository<FacRoom>, IFacRoomRepository
{
    public FacRoomRepository(DormiTechContext context, IClaimsServices claimsService) : base(context, claimsService)
    {
    }
}