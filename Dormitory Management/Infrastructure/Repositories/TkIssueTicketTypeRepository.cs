using Domain.Model;
using Application.Abstractions.IRepository;
using Microsoft.EntityFrameworkCore;
using Application.Services.IServices;
using Infrastructure.Repositories;

namespace Infrastructure.Repositories
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