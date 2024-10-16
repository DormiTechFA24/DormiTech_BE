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
    internal sealed class TkIssueTicketPhotoRepository : GenericRepository<TkIssueTicketPhoto>, ITkIssueTicketPhotoRepository
    {
        private readonly DbSet<TkIssueTicketPhoto> context;

        public TkIssueTicketPhotoRepository(DormiTechContext context, IClaimsServices claimsService) : base(context, claimsService)
        {
            this.context = context.Set<TkIssueTicketPhoto>();
        }

        public async Task<List<TkIssueTicketPhoto>> GetByTicketId(Guid id)
        {
            var query = await context.Where(s => s.TicketId.Equals(id)).ToListAsync();

            return query;
        }
    }
}
