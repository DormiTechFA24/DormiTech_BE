using Domain.Model;
using Infrastructure.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    internal sealed class TkIssueTicketStatusRepository : ITkIssueTicketStatusRepository
    {
        private readonly DbSet<TkIssueTicketStatus> context;

        public TkIssueTicketStatusRepository(DormiTechContext context)
        {
            this.context = context.Set<TkIssueTicketStatus>();
        }

        public async Task<IEnumerable<TkIssueTicketStatus>> GetAll()
        {
            IQueryable<TkIssueTicketStatus> query = context;

            return query;
        }

        public async Task<TkIssueTicketStatus> GetById(Guid id)
        {
            IQueryable<TkIssueTicketStatus> query = context;

            return await query.FirstOrDefaultAsync();
        }
    }
}