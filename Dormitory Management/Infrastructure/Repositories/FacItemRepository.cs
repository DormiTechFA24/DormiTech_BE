using Application.IServices;
using Domain.Model;
using Infrastructure.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public sealed class FacItemRepository : GenericRepository<FacItem>, IFacItemRepository
{
    public FacItemRepository(DormiTechContext context, IClaimsServices claimsService) : base(context, claimsService)
    {
    }
}