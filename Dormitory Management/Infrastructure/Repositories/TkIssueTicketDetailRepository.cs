using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;
using Infrastructure.Repositories;

namespace Infrastructure.Repositories
{
    internal sealed class TkIssueTicketDetailRepository : GenericRepository<TkIssueTicketDetail>, ITkIssueTicketDetailRepository
    {
        private readonly DbSet<TkIssueTicketDetail> context;

        public TkIssueTicketDetailRepository(DormiTechContext context, IClaimsServices claimsService) : base(context, claimsService)
        {
            this.context = context.Set<TkIssueTicketDetail>();
        }

        public async Task<List<TkIssueTicketDetail>> GetByTicketId(Guid id)
        {
            var query = await context.Where(s => s.TicketId.Equals(id)).ToListAsync();

            return query;
        }
    }
}
