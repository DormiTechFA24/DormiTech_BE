using Application.Services.IServices;
using Domain.Model;
using Infrastructure.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public sealed class SysAccountRepository : GenericRepository<SysAccount>, ISysAccountRepository
{
    public SysAccountRepository(DormiTechContext context, IClaimsServices claimsService) : base(context, claimsService)
    {
    }
}