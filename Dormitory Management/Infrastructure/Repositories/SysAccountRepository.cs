using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;

namespace Infrastructure.Repositories;

public sealed class SysAccountRepository : GenericRepository<SysAccount>, ISysAccountRepository
{
    public SysAccountRepository(DormiTechContext context, IClaimsServices claimsService) : base(context, claimsService)
    {
    }
}