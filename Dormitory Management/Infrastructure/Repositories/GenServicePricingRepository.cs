using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;

namespace Infrastructure.Repositories
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