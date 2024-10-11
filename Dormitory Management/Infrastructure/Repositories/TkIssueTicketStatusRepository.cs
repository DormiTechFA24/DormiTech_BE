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
