using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;

namespace Infrastructure.Repositories;

public sealed class FacRoomItemRepository : GenericRepository<FacRoomItem>, IFacRoomItemRepository
{
    public FacRoomItemRepository(DormiTechContext context, IClaimsServices claimsService) : base(context, claimsService)
    {
    }
}