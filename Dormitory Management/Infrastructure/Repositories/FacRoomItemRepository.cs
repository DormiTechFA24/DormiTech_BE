using Application.IServices;
using Application.Utils;
using Domain.Model;
using Infrastructure.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Infrastructure.Repositories;

public sealed class FacRoomItemRepository : GenericRepository<FacRoomItem>, IFacRoomItemRepository
{
    public FacRoomItemRepository(DormiTechContext context, IClaimsServices claimsService) : base(context, claimsService)
    {
    }
}