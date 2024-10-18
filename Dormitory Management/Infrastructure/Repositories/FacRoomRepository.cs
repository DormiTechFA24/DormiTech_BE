using Application.Services.IServices;
using Domain.Model;
using Infrastructure.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public sealed class FacRoomRepository : GenericRepository<FacRoom>, IFacRoomRepository
{
    public FacRoomRepository(DormiTechContext context, IClaimsServices claimsService) : base(context, claimsService)
    {
    }
}