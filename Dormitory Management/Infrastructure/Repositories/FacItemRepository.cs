using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;

namespace Infrastructure.Repositories;

public sealed class FacItemRepository : GenericRepository<FacItem>, IFacItemRepository
{
    public FacItemRepository(DormiTechContext context, IClaimsServices claimsService) : base(context, claimsService)
    {
    }
}