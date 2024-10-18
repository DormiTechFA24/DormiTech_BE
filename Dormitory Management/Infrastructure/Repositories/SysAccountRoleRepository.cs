using Application.Services.IServices;
using Domain.Model;
using Infrastructure.Abstractions.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    internal class SysAccountRoleRepository : GenericRepository<Domain.Model.SysRole>, ISysAccountRoleRepository
    {
        public SysAccountRoleRepository(DormiTechContext context, IClaimsServices claimsService) : base(context, claimsService)
        {
        }
    }
}
