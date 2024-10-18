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
    public class GenAmenityRepository : GenericRepository<GenAmenity>, IGenAmenityRepository
    {
        public GenAmenityRepository(DormiTechContext context, IClaimsServices claimsService) : base(context, claimsService)
        {
        }
    }
}
