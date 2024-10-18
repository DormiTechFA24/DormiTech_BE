using Application.Services.IServices;
using Domain.Model;
using Infrastructure.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public sealed class SysRoleRepository : GenericRepository<SysRole>, ISysRoleRepository
{
    public SysRoleRepository(DormiTechContext context, IClaimsServices claimsService) : base(context, claimsService)
    {
    }
}