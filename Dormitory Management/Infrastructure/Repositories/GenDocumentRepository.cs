using Domain.Model;
using Infrastructure.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public sealed class GenDocumentRepository : IGenDocumentRepository
    {
        private readonly DbSet<GenDocument> context;

        public GenDocumentRepository(DormiTechContext context)
        {
            this.context = context.Set<GenDocument>();
        }

        public async Task<IEnumerable<GenDocument>> GetAll()
        {
            IQueryable<GenDocument> query = context;

            return query;
        }

        public async Task<GenDocument> GetById(Guid id)
        {
            IQueryable<GenDocument> query = context;

            return await query.FirstOrDefaultAsync();
        }
    }
}