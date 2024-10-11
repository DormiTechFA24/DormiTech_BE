using Domain.Model;
using Infractstructure.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infractstructure.Repositories
{
    internal sealed class GenServicePricingRepository : IGenServicePricingRepository
    {
        private readonly DbSet<GenServicePricing> context;

        public GenServicePricingRepository(DormiTechContext context)
        {
            this.context = context.Set<GenServicePricing>();
        }

        public async Task<IEnumerable<GenServicePricing>> GetAll()
        {
            IQueryable<GenServicePricing> query = context;

            return query;
        }

        public async Task<GenServicePricing> GetById(Guid id)
        {
            IQueryable<GenServicePricing> query = context;

            return await query.FirstOrDefaultAsync();
        }
    }
}
