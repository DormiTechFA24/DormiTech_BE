using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;
using Infrastructure.Repositories;

public sealed class SysRoleRepository : GenericRepository<SysRole>, ISysRoleRepository
{
    public SysRoleRepository(DormiTechContext context, IClaimsServices claimsService) : base(context, claimsService)
    {
    }
}