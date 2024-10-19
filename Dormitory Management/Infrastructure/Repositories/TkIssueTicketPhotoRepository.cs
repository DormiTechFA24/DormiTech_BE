using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;
using Infrastructure.Repositories;

namespace Infrastructure.Repositories
{
    public sealed class TkIssueTicketPhotoRepository : GenericRepository<TkIssueTicketPhoto>, ITkIssueTicketPhotoRepository
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
