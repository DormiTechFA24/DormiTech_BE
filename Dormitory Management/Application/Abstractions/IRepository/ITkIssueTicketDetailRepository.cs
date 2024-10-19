using Domain.Model;
using Application.Abstractions.IRepository;

namespace Application.Abstractions.IRepository
{
    public interface ITkIssueTicketDetailRepository : IGenericRepository<TkIssueTicketDetail>
    {
        Task<List<TkIssueTicketDetail>> GetByTicketId(Guid id);
    }
}
