using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;

namespace Infrastructure.Repositories
{
    internal sealed class GenPayTypeRepository : IGenPayTypeRepository
    {
        private readonly DbSet<GenPayType> context;

        public GenPayTypeRepository(DormiTechContext context)
        {
            this.context = context.Set<GenPayType>();
        }

        public async Task<IEnumerable<GenPayType>> GetAll()
        {
            IQueryable<GenPayType> query = context;

            return query;
        }

        public async Task<GenPayType> GetById(Guid id)
        {
            IQueryable<GenPayType> query = context;

            return await query.FirstOrDefaultAsync();
        }
    }
}