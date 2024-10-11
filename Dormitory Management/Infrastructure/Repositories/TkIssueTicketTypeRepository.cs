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
    internal sealed class TkIssueTicketTypeRepository : ITkIssueTicketTypeRepository
    {
        private readonly DbSet<TkIssueTicketType> context;

        public TkIssueTicketTypeRepository(DormiTechContext context)
        {
            this.context = context.Set<TkIssueTicketType>();
        }

        public async Task<IEnumerable<TkIssueTicketType>> GetAll()
        {
            IQueryable<TkIssueTicketType> query = context;

            return query;
        }

        public async Task<TkIssueTicketType> GetById(Guid id)
        {
            IQueryable<TkIssueTicketType> query = context;

            return await query.FirstOrDefaultAsync();
        }
    }
}
