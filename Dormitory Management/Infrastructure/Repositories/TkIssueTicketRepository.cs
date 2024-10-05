using Domain.Abstractions.IRepository;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public sealed class TkIssueTicketRepository : ITkIssueTicketRepository
{
    private readonly DbSet<TkIssueTicket> context;

    public TkIssueTicketRepository(DormiTechContext context)
    {
        this.context = context.Set<TkIssueTicket>();
    }

    public void Create(TkIssueTicket tkIssueTicket)
    {
        context.Add(tkIssueTicket);
    }

    public async Task<TkIssueTicket> Detail(Guid id)
    {
        IQueryable<TkIssueTicket> query = context;

        return await query.FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<TkIssueTicket>> Get()
    {
        IQueryable<TkIssueTicket> query = context;

        return query;
    }

    public async Task<IEnumerable<TkIssueTicket>> Search(Guid? ticketOwner, DateTime? CreatedOn, DateTime? approvedOn, int ticketStatusId = 0, int ticketTypeId = 0, string header = "")
    {
        IQueryable<TkIssueTicket> query = context;

        return query;
    }

    public void Update(TkIssueTicket tkIssueTicket)
    {
        context.Update(tkIssueTicket);
    }
}
