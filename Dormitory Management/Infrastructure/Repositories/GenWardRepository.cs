using Domain.Model;
using Infrastructure.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    internal sealed class GenWardRepository : IGenWardRepository
    {
        private readonly DbSet<GenWard> context;

        public GenWardRepository(DormiTechContext context)
        {
            this.context = context.Set<GenWard>();
        }

        public async Task<IEnumerable<GenWard>> GetAll()
        {
            IQueryable<GenWard> query = context;

            return query;
        }

        public async Task<GenWard> GetById(Guid id)
        {
            IQueryable<GenWard> query = context;

            return await query.FirstOrDefaultAsync();
        }
    }
}