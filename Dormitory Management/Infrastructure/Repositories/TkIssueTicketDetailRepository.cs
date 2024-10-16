using Application.IServices;
using Domain.Model;
using Infrastructure.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
